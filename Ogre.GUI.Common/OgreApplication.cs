using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.ogre;

namespace Ogre.GUI.Common
{
    public class OgreApplication : ApplicationContextBase
    {
        private readonly System.Windows.Forms.Timer timer;
        private readonly Panel renderPanel;
        private readonly IntPtr handle;
        private readonly object lockObject = new object();
        private CameraMan cameraMan;
        private float yaw;
        private float pitch;
        private float distance;
        private float zoomDistance = 0.5f;
        private bool isDragging;
        private Point prevMouseLocation;
        private bool disposed;

        public OgreApplication(Panel renderPanel)
        {
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Tick += this.Timer_Tick;
            this.timer.Interval = 100;

            this.renderPanel = renderPanel;
            this.handle = this.renderPanel.Handle;
            this.SetupRenderPanelEvents(true);
            Task.Run(this.Start);
        }

        public override void Dispose()
        {
            if (!this.disposed)
            {
                this.disposed = true;
                this.SetupRenderPanelEvents(false);
                this.timer.Stop();
                this.timer.Dispose();

                this.cameraMan = null;
            }

            base.Dispose();
        }

        private void SetupRenderPanelEvents(bool enable)
        {
            if (enable)
            {
                this.renderPanel.Resize += this.Resize;
                this.renderPanel.MouseDown += this.OnMouseDown;
                this.renderPanel.MouseUp += this.OnMouseUp;
                this.renderPanel.MouseLeave += this.OnMouseLeave;
                this.renderPanel.MouseMove += this.OnMouseMove;
                this.renderPanel.MouseWheel += this.OnMouseWheel;
            }
            else
            {
                this.renderPanel.Resize -= this.Resize;
                this.renderPanel.MouseDown -= this.OnMouseDown;
                this.renderPanel.MouseUp -= this.OnMouseUp;
                this.renderPanel.MouseLeave -= this.OnMouseLeave;
                this.renderPanel.MouseMove -= this.OnMouseMove;
                this.renderPanel.MouseWheel -= this.OnMouseWheel;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lock (this.lockObject)
            {
                this.getRoot().renderOneFrame();
            }
        }

        private void Start()
        {
            var bg = Thread.CurrentThread.IsBackground;
            this.initApp();

            this.renderPanel.SynchronizedInvoke(() =>
            {
                this.timer.Enabled = true;
                this.renderPanel.Visible = true;
                this.renderPanel.Focus();
            });
        }

        public void RenderOne()
        {
            this.getRoot().renderOneFrame();
        }

        private void Resize(object sender, EventArgs e)
        {
            var win = this.getRenderWindow();
            win.windowMovedOrResized();
            this.windowResized(win);
        }

        public override void setup()
        {
            base.setup();

            var root = this.getRoot();
            var sceneManager = root.createSceneManager();

            var shaderGenerator = ShaderGenerator.getSingleton();
            shaderGenerator.addSceneManager(sceneManager); // must be done before we do anything with the scene

            sceneManager.setAmbientLight(new ColourValue(.1f, .1f, .1f));

            var light = sceneManager.createLight("MainLight");
            var lightnode = sceneManager.getRootSceneNode().createChildSceneNode();
            lightnode.setPosition(0f, 10f, 15f);
            lightnode.attachObject(light);

            var camera = sceneManager.createCamera("myCam");
            camera.setAutoAspectRatio(true);
            camera.setNearClipDistance(5);
            var camnode = sceneManager.getRootSceneNode().createChildSceneNode();
            camnode.attachObject(camera);

            this.cameraMan = new CameraMan(camnode);
            this.cameraMan.setStyle(CameraStyle.CS_ORBIT);
            this.yaw = 0;
            this.pitch = 0.3f;
            this.distance = 15f;

            this.cameraMan.setYawPitchDist(new Radian(this.yaw), new Radian(this.pitch), this.distance);

            var viewport = this.getRenderWindow().addViewport(camera);
            viewport.setBackgroundColour(new ColourValue(.3f, .3f, .3f));

            var ent = sceneManager.createEntity("Sinbad.mesh");
            var node = sceneManager.getRootSceneNode().createChildSceneNode();
            node.attachObject(ent);

            //var br = ent.getBoundingRadius();
            //br *= 1.25f;
            //this.zoomDistance = br * 0.1f;
        }

        public override NativeWindowPair createWindow(string name, uint w, uint h, NameValuePairList miscParams)
        {
            //return base.createWindow(name, w, h, miscParams);
            miscParams["externalWindowHandle"] = this.handle.ToString();

            var ret = base.createWindow(name, w, h, miscParams);

            w = ret.render.getWidth();
            h = ret.render.getHeight();

            // update Form
            //this.renderPanel.Text = name;
            //this.renderPanel.Width = (int)w;
            //this.renderPanel.Height = (int)h;

            return ret;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (this.isDragging)
            {
                var delta = new Point(e.Location.X - this.prevMouseLocation.X, e.Location.Y - this.prevMouseLocation.Y);
                this.yaw -= delta.X * 0.01f;
                this.pitch += delta.Y * 0.01f;
                this.cameraMan?.setYawPitchDist(new Radian(this.yaw), new Radian(this.pitch), this.distance);
            }

            this.prevMouseLocation = e.Location;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            this.isDragging = true;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.isDragging = false;
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            this.isDragging = false;
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.distance -= this.zoomDistance;
            }
            else
            {
                this.distance += this.zoomDistance;
            }

            this.cameraMan?.setYawPitchDist(new Radian(this.yaw), new Radian(this.pitch), this.distance);
        }

        public void Shutdown()
        {
            this.timer.Stop();
            lock (this.lockObject)
            {
                this.shutdown();
            }

            this.Dispose();
        }
    }
}