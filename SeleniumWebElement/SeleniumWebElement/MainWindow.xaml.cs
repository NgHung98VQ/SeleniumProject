using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
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

namespace SeleniumWebElement
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
            var searchBar = chromeDriver.FindElementByXPath("/html/body/header/div[1]/div/div/a[1]");
            searchBar.Click();
            var searchBar1 = chromeDriver.FindElementByXPath("/html/body/section/aside[1]/ul[1]/li[1]/a/h3");
            searchBar1.Click();

            chromeDriver.ExecuteAsyncScript("var content = document.getElementsByClassName('titledetail')[1].children[0].innerHTML; arlert(content); ");
            IJavaScriptExecutor js = chromeDriver as IJavaScriptExecutor;
            var dataFromJS = (string)js.ExecuteAsyncScript("var content = document.getElementsByClassName('titledetail')[1].children[0].innerHTML; arlert(content);");
            MessageBox.Show(dataFromJS);
            
           

        }
    }
}
