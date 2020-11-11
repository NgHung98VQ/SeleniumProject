using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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

namespace SeleniumProxy
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            FirefoxProfile firefoxProfile = new FirefoxProfile();
            firefoxProfile.SetPreference("network./proxy.type", 1);
            firefoxProfile.SetPreference("Network.proxy.http", "36.89.183.253");
            firefoxProfile.SetPreference("network.proxy.http_port", 33381);
            firefoxProfile.SetPreference("network.proxy.ssl", "36.89.183.253");
            firefoxProfile.SetPreference("network.proxy.ssl_port", 33381);
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.Profile = firefoxProfile;
            FirefoxDriver firefoxDriver = new FirefoxDriver(firefoxOptions);
            firefoxDriver.Url = "https://whoer.net/";
            firefoxDriver.Navigate();
        }

    }
       
}
