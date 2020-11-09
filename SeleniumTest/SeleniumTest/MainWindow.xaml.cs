using OpenQA.Selenium.Chrome;
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

namespace SeleniumTest
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
        ChromeOptions chromeOptions = new ChromeOptions();
        ChromeDriver drv;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            chromeOptions.AddArguments(@"user-data-dir=C:\Users\Sharkily\AppData\Local\Google\Chrome\User Data\Profile 1");
            drv = new ChromeDriver(chromeOptions);
           
        }
    }
}
