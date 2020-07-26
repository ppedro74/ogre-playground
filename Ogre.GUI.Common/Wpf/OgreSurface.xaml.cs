using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ogre.GUI.Common.Wpf
{
    /// <summary>
    /// Interaction logic for OgreSurface.xaml
    /// </summary>
    public partial class OgreSurface : UserControl
    {
        public OgreSurface()
        {
            InitializeComponent();
        }

        public void Start()
        {
            this.OgreSurface1.Start();
        }
    }
}
