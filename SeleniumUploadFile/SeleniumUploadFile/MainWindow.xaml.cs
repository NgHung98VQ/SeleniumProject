using OpenQA.Selenium.Firefox;
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

namespace SeleniumUploadFile
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
            // khởi tạo WebDriver
            FirefoxDriver firefoxDriver = new FirefoxDriver();
            firefoxDriver.Manage().Window.Maximize();

            // chuyển trang đến website secufiles.com tìm đại ở google và thấy khá dễ demo
            firefoxDriver.Url = "https://secufiles.com/";
            firefoxDriver.Navigate();

            firefoxDriver.FindElementById("initialUploadSection").SendKeys(@"D:\TUYỂN TẬP ẢNH\Bachkhoa_logo.jpg");
            firefoxDriver.Click().
            
            

           firefoxDriver.FindElementByXPath("/html/body/section[1]/div/div/ul/li/div[4]/a");
           
           


            Thread.Sleep(4000);
            firefoxDriver.Quit();
            
        }
    }
}
