using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace SeleniumRTTC
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
            firefoxProfile.SetPreference("media.peerconnection.enabled", false);
            

            FirefoxOptions firefoxOptions = new FirefoxOptions();

            firefoxOptions.Profile = firefoxProfile;
            FirefoxDriver firefoxDriver = new FirefoxDriver(firefoxOptions);
            


            // chuyển trang đến website howkteam.com
            firefoxDriver.Url = "https://whoer.net/";
            firefoxDriver.Navigate();
        }
    }
}
