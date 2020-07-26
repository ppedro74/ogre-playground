using System.Runtime.InteropServices;
using System.Windows.Forms;
using org.ogre;

namespace OgreForms
{
    public class Example : ApplicationContextBase
    {
        private Form form;

        public Example()
        {
            this.form = new Form();
            this.form.Resize += this.Resize;
            this.form.KeyDown += this.KeyDown;
            this.form.Closing += this.Closing;
            // TODO: prevent drawing of Form, since Ogre draws over anyway

            this.form.Show();
        }

        private void Resize(object sender, System.EventArgs e)
        {
            var win = this.getRenderWindow();
            win.windowMovedOrResized();
            this.windowResized(win);
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.getRoot().queueEndRendering();
        }

        private void Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.getRoot().queueEndRendering();
        }

        public override NativeWindowPair createWindow(string title, uint w, uint h, NameValuePairList miscParams)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                miscParams["parentWindowHandle"] = this.form.Handle.ToString();
            else
                miscParams["externalWindowHandle"] = this.form.Handle.ToString();

            var ret = base.createWindow(title, w, h, miscParams);

            w = ret.render.getWidth();
            h = ret.render.getHeight();

            // update Form
            this.form.Text = title;
            this.form.Width = (int) w;
            this.form.Height = (int) h;

            return ret;
        }

        public override void setup()
        {
            base.setup();

            var root = this.getRoot();
            var scnMgr = root.createSceneManager();

            var shadergen = ShaderGenerator.getSingleton();
            shadergen.addSceneManager(scnMgr); // must be done before we do anything with the scene

            scnMgr.setAmbientLight(new ColourValue(.1f, .1f, .1f));

            var light = scnMgr.createLight("MainLight");
            var lightnode = scnMgr.getRootSceneNode().createChildSceneNode();
            lightnode.setPosition(0f, 10f, 15f);
            lightnode.attachObject(light);

            var cam = scnMgr.createCamera("myCam");
            cam.setAutoAspectRatio(true);
            cam.setNearClipDistance(5);
            var camnode = scnMgr.getRootSceneNode().createChildSceneNode();
            camnode.attachObject(cam);

            var camman = new CameraMan(camnode);
            camman.setStyle(CameraStyle.CS_ORBIT);
            camman.setYawPitchDist(new Radian(0), new Radian(0.3f), 15f);

            var vp = this.getRenderWindow().addViewport(cam);
            vp.setBackgroundColour(new ColourValue(.3f, .3f, .3f));

            var ent = scnMgr.createEntity("Sinbad.mesh");
            var node = scnMgr.getRootSceneNode().createChildSceneNode();
            node.attachObject(ent);
        }

        private static void Main()
        {
            var app = new Example();
            app.initApp();

            while (!app.getRoot().endRenderingQueued())
            {
                Application.DoEvents();
                app.getRoot().renderOneFrame();
            }

            app.closeApp();
        }
    }
}