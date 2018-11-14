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

namespace Switcherino
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

        private void SwapSignIn(object sender, RoutedEventArgs e)
        {
            Window signInWindow = new SignIn();
            signInWindow.Show();
            this.Close();
        }

        private void SwapPhoneEmail(object sender, RoutedEventArgs e)
        {
            Window phoneEmailWindow = new PhoneEmail();
            phoneEmailWindow.Show();
            this.Close();
        }

        private void SwapDownloadData(object sender, RoutedEventArgs e)
        {
            Window downloadDataWindow = new DownloadData();
            downloadDataWindow.Show();
            this.Close();
        }
    }
}
