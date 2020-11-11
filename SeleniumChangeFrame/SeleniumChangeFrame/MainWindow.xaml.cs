using OpenQA.Selenium.Firefox;
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

namespace SeleniumChangeFrame
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

            // chuyển trang đến website howkteam.com
            firefoxDriver.Url = "http://www.howkteam.vn/course/note--tips--trick--net/thao-tac-voi-excel-trong-c-1575";
            firefoxDriver.Navigate();

            // bắt ra trình play video của youtube có id là ytplayer
            var youtubePlayer = firefoxDriver.FindElementById("ytplayer");

            // click vào nó để phát video -> hiện ra button youtube để nhấn
            youtubePlayer.Click();

            // change qua frame của ytplayer
            firefoxDriver.SwitchTo().Frame(youtubePlayer);
            // tìm ra nút youtube và nhấn vào nó để chuyển qua youtube
            var youtube = firefoxDriver.FindElementByCssSelector(".ytp-youtube-button");
            youtube.Click();
        }
             
    }
}
