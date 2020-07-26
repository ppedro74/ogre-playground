using System;
using System.Windows.Forms;
using Ogre.GUI.Common.Forms;

namespace OgreForms
{
    public partial class MainForm : Form
    {
        private readonly OgreSurface ogreSurface;

        public MainForm()
        {
            this.InitializeComponent();

            this.ogreSurface = new OgreSurface {Dock = DockStyle.Fill};
            this.Panel1.Controls.Add(this.ogreSurface);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.ogreSurface.Start();
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            this.ogreSurface.RenderOne();
        }
    }
}