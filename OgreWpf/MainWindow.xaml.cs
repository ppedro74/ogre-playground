using System.Windows;

namespace OgreWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            this.OgreSurface1.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PausedCb_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}