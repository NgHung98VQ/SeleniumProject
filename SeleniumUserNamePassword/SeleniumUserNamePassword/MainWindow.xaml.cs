using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Proxy_Profile_Selenium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ProfileFolderPath = "Profile";
        string ExtentionFolderPath = "Extention";
        ChromeDriver driver;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // thoát driver đang có
            if (driver != null)
            {
                try
                {
                    driver.Close();
                    driver.Quit();
                }
                catch (Exception ex)
                {
                }
            }

            ChromeOptions options = new ChromeOptions();

            if (!Directory.Exists(ProfileFolderPath))
            {
                Directory.CreateDirectory(ProfileFolderPath);
            }

            if (Directory.Exists(ProfileFolderPath))
            {
                int nameCount = 0;

                options.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + nameCount);
            }


            driver = new ChromeDriver(options);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string ip = "186.250.14.53:8388";
            string username = "username";
            string pass = "password";

            // thoát driver đang có
            if (driver != null)
            {
                try
                {
                    driver.Close();
                    driver.Quit();
                }
                catch (Exception ex)
                {
                }
            }

            ChromeOptions options = new ChromeOptions();

            if (!string.IsNullOrEmpty(ip))
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(pass))
                {
                    options.AddExtensions(ExtentionFolderPath + "Proxy Auto Auth.crx");
                }
                options.AddArgument(string.Format("--proxy-server={0}", ip));
            }

            driver = new ChromeDriver(options);

            if (!string.IsNullOrEmpty(ip))
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(username))
                {
                    driver.Url = "chrome-extension://ggmdpepbjljkkkdaklfihhngmmgmpggp/options.html";
                    driver.Navigate();

                    driver.FindElementById("login").SendKeys(username);
                    driver.FindElementById("password").SendKeys(pass);
                    driver.FindElementById("retry").Clear();
                    driver.FindElementById("retry").SendKeys("2");

                    driver.FindElementById("save").Click();
                }
            }

            driver.Navigate().GoToUrl("https://whoer.net/");
        }
    }
}