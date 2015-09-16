using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace GitDemoApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Timer _timer;

        private new void MouseEnter(object sender, MouseEventArgs e)
        {
            _timer = new Timer(state =>
            {
                if (lblFlashy == null)
                    return;
                lblFlashy.Background = Equals(lblFlashy.Background, Brushes.Green) ? Brushes.DarkRed : Brushes.Green;
            }, null, 0, 30);
        }
    }
}
