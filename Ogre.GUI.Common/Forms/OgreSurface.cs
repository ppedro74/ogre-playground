using System;
using System.Windows.Forms;

namespace Ogre.GUI.Common.Forms
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class OgreSurface : UserControl
    {
        private readonly Panel renderPanel;
        private OgreApplication ogreApplication;
        //private bool isDragging;
        //private Point prevMouseLocation;

        public OgreSurface()
        {
            this.InitializeComponent();

            this.renderPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Visible = false
            };

            this.Controls.Add(this.renderPanel);
        }

        public void Start()
        {
            if (this.ogreApplication != null)
            {
                return;
            }

            this.ogreApplication = new OgreApplication(this.renderPanel);
        }

        public void RenderOne()
        {
            this.ogreApplication?.RenderOne();
        }


        protected override void OnHandleDestroyed(EventArgs e)
        {
            this.ogreApplication?.Shutdown();
            this.ogreApplication = null;
            base.OnHandleDestroyed(e);
        }

        //protected override void OnMouseWheel(MouseEventArgs e)
        //{
        //    base.OnMouseWheel(e);
        //    this.ogreApplication.OnMouseWheel(e);
        //}

        //protected override void OnMouseDown(MouseEventArgs e)
        //{
        //    base.OnMouseDown(e);
        //    this.isDragging = true;
        //}

        //protected override void OnMouseUp(MouseEventArgs e)
        //{
        //    base.OnMouseUp(e);
        //    this.isDragging = false;
        //}

        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    base.OnMouseLeave(e);
        //    this.isDragging = false;
        //}

        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);
        //    if (this.isDragging)
        //    {
        //        this.ogreApplication.OnMouseMove(e, this.prevMouseLocation);
        //    }
        //    this.prevMouseLocation = e.Location;
        //}
    }
}