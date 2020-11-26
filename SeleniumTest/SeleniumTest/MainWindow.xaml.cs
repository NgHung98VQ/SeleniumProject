using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            FirefoxOptions options = new FirefoxOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
            FirefoxDriver firefoxDriver = new FirefoxDriver(options);
            firefoxDriver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail&hl=vi&dsh=S-1912004215%3A1605517180343180&gmb=exp&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";
            firefoxDriver.Navigate();
            var name = firefoxDriver.FindElementByCssSelector("input[id='lastName']");
            name.SendKeys("lastname");
            var firstname = firefoxDriver.FindElementByCssSelector("input[id='firstName']");
            firstname.SendKeys("firstname");
            var username = firefoxDriver.FindElementByCssSelector("input[id='username']");
            username.SendKeys("suttoanxitbk");
            var password = firefoxDriver.FindElementByCssSelector("input[name='Passwd']");
            password.SendKeys("01233765221");
            var confirmpassword = firefoxDriver.FindElementByCssSelector("input[name='ConfirmPasswd']");
            confirmpassword.SendKeys("01233765221");
            var next = firefoxDriver.FindElementByCssSelector("div[id='accountDetailsNext']");
            next.Click();
            var phonenumber = firefoxDriver.FindElementByCssSelector("input[id='phoneNumberId']");
            phonenumber.SendKeys("+84896994744");
            var next1 = firefoxDriver.FindElementByCssSelector("div[class='VfPpkd-RLmnJb");
            next1.Click();
            var confirmphoneNumber = firefoxDriver.FindElementByCssSelector("input[id='code']");
            confirmphoneNumber.SendKeys("");


        } 

        
    }
}
