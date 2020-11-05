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

namespace SeleniumExcuteJaveScript
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
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://www.thegioididong.com/";
            chromeDriver.Navigate();
            var searchBar = chromeDriver.FindElementById("search-keyword");
            searchBar.SendKeys("iphone 11 pro max");
            var tagssearch= chromeDriver.FindElementByClassName("btntop");
            tagssearch.Click();
            chromeDriver.Url = "https://www.thegioididong.com/dtdd/iphone-11-pro-max";
            chromeDriver.Navigate();
            chromeDriver.ExecuteAsyncScript("var content = document.getElementsByClassName('fixbody')[0].children[0].innerHTML;alert(content);");
            IJavaScriptExecutor js = chromeDriver as IJavaScriptExecutor;
            var dataFromJS = (string)js.ExecuteScript("var content = document.getElementsByClassName('fixbody')[0].children[0].innerHTML;return content;");
            MessageBox.Show(dataFromJS);

        }
    }
}
