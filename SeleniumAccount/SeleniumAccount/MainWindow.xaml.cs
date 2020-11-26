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

namespace SeleniumAccount
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
         
            

                ChromeDriver chromeDriver = new ChromeDriver();
            int i;
           
            for (i = 0; i < 10; i++)
            {
                chromeDriver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F%3Fpc%3Dtopnav-about-n-en&flowName=GlifWebSignIn&flowEntry=SignUp";
                chromeDriver.Navigate();

                chromeDriver.SwitchTo().ParentFrame();
                var name = chromeDriver.FindElementByCssSelector("input[id='lastName']");
                 
                name.SendKeys("lastname"+i);
                var firstname = chromeDriver.FindElementByCssSelector("input[id='firstName']");
                firstname.SendKeys("firstname"+i);
                var username = chromeDriver.FindElementByCssSelector("input[id='username']");
                username.SendKeys("suttoanxitbk"+i);
                var password = chromeDriver.FindElementByCssSelector("input[name='Passwd']");
                password.SendKeys("01233765221");
                var confimpassword = chromeDriver.FindElementByCssSelector("input[name='ConfirmPasswd']");
                confimpassword.SendKeys("01233765221");
                var next = chromeDriver.FindElementByCssSelector("div[id='accountDetailsNext']");
                next.Click();
                



            }
            
        }
        
    }
}
