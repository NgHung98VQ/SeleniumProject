using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

namespace SeleniumShare
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
        private void Button_Click(object sender , RoutedEventArgs e)

        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
             ChromeDriver chromeDriver= new ChromeDriver(options);
           
            chromeDriver.Url = "https://www.facebook.com/";
            chromeDriver.Navigate();
            var username = chromeDriver.FindElementByXPath("//*[@id=\"email\"]");
            username.SendKeys("0856929973");
            var password = chromeDriver.FindElementByXPath("//*[@id=\"pass\"]");
            password.SendKeys("01647300004");
            var login = chromeDriver.FindElementByName("login");
            login.Click();
            var searchFanpage = chromeDriver.FindElementByCssSelector("input[type='search']");
            searchFanpage.SendKeys("aobongda.net");
            searchFanpage.FindElement(By.CssSelector("body[class='_6s5d _71pn _-kb segoe']")).SendKeys(Keys.Enter);
           
            var click = chromeDriver.FindElementByClassName("nc684nl6");
            click.Click();


        }
    }
}
