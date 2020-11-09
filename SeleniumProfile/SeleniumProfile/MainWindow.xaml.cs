using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Internal;
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

namespace SeleniumProfile
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
            /*FirefoxProfile firefoxProfile = new FirefoxProfile(@"C:\Users\Sharkily\AppData\Local\Temp\rust_mozprofile6NUFyK");
            FirefoxOptions firefoxOptions = new FirefoxOptions();

            firefoxOptions.AddArguments();
            FirefoxDriver firefoxDriver = new FirefoxDriver(firefoxOptions);*/

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument(@"--user-data-dir=C:C:\SeleniumProfiles");
            ChromeDriver chromeDriver = new ChromeDriver(chromeOptions);
        }
    }
}
