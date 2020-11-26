using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Newtonsoft.Json;

namespace SeleniumWeather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string APPID = "542ffd081e67f4512b705f89d2a611b2";
        string cityName = "Colombo";

        

        public MainWindow()
        {
            InitializeComponent();
            getWeather("America");// one day weather
            getForcast("America");// more than one day
        }

       

        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {


                string Url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APPID);
                var json = web.DownloadString(Url);
                var result = JsonConvert.DeserializeObject<weatherInfor.Root>(json);
                weatherInfor.Root outPut = result;
                lbl_cityName.Content = string.Format("{0}", outPut.name);
                lbl_country.Content = string.Format("{0}", outPut.sys.country);
                lbl_Temp.Content = string.Format("{0}\00B0" + "C", outPut.main.temp);

                
                
                
            }
            
        }

        
        void getForcast(string city)
        {
            int day = 5;
            string Url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt={1}&APPID={2}", city, day, APPID);
            using(WebClient web = new WebClient())
            {
                var json = web.DownloadString(Url);
                var Object = JsonConvert.DeserializeObject<weatherForcast>(json);
                weatherForcast forecast = Object;
                lbl_day.Content = string.Format("{0}", forecast.list[1].dt);
                lbl_condition.Content = string.Format("{0}", forecast.list[1].weather[0].main);// weather condition
                lbl_description.Content = string.Format("{0}", forecast.list[1].weather[0].description);// weather description
                lbl_temp.Content = string.Format("{0}\u00B0", forecast.list[1].temp.day);//weather temp
                lbl_speed.Content = string.Format("{0} km/h", forecast.list[1].speed);//waether speed
                
            }
            
        }

      

        DateTime getDate(double millisecond)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecond).ToLocalTime();
            return day;
        }
        ImageSource setIcon(string iconID)
        {
            string Url = string.Format("http://openweathermap.org/img/w/{0}.png", iconID);//weather icon resource
            var request = WebRequest.Create(Url);
            using (var response = request.GetResponse())
                using (var weatherIcon = response.GetResponseStream())
            {
                ImageSource weatherImg = BitmapImage.Create()
                return weatherImg;

            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (txt_cityName.Text != "")
            {
                getWeather(txt_cityName.Text);
                getForcast(txt_cityName.Text);
            }
        }
    }
}
