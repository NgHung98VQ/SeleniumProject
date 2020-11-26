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

namespace SeleniumNewAccountGmail
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
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
            ChromeDriver chromeDriver = new ChromeDriver(options);
            chromeDriver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail&hl=vi&dsh=S-1912004215%3A1605517180343180&gmb=exp&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";
            chromeDriver.Navigate();
            var name = chromeDriver.FindElementByCssSelector("input[id='lastName']");
            name.SendKeys("lastname");
            var firstname = chromeDriver.FindElementByCssSelector("input[id='firstName']");
            firstname.SendKeys("firstname");
            var username = chromeDriver.FindElementByCssSelector("input[id='username']");
            username.SendKeys("suttoanxitbk");
            var password = chromeDriver.FindElementByCssSelector("input[name='Passwd']");
            password.SendKeys("01233765221");
            var confirmpassword = chromeDriver.FindElementByCssSelector("input[name='ConfirmPasswd']");
            confirmpassword.SendKeys("01233765221");
            var next = chromeDriver.FindElementByCssSelector("div[id='accountDetailsNext']");
            next.Click();
            var phonenumber = chromeDriver.FindElementByCssSelector("input[id='phoneNumberId']");
            phonenumber.SendKeys("+84896994744");
            var next1 = chromeDriver.FindElementByCssSelector("input[class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc']");
            next1.Click();
        } 
    }
}

