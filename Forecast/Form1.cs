using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace Forecast
{
    public partial class Form1 : Form
    {
        //Api key = your API key
        //https://api.openweathermap.org/data/2.5/weather?q={city name}&units=metric&appid={API key}

        public Form1()
        {
            InitializeComponent();
        }


        private void SearchCityEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getWeather();
            }
            if (e.KeyCode == Keys.Escape)
            {
                CityTextBox.Text = "";
            }
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string city = CityTextBox.Text;
                string APIKey = "your API key";

                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", CityTextBox.Text, APIKey);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    TempTextBox.Text = Info.main.temp.ToString() + "°C";
                    MaxTempTextBox.Text = Info.main.temp_max.ToString() + "°C";
                    MinTempTextBox.Text = Info.main.temp_min.ToString() + "°C";
                    HumidityTextBox.Text = Info.main.humidity.ToString() + "%";

                    var sunriseUTC = DateTimeOffset.FromUnixTimeSeconds(Int32.Parse(Info.sys.sunrise.ToString())).DateTime.ToShortTimeString();
                    var sunsetUTC = DateTimeOffset.FromUnixTimeSeconds(Int32.Parse(Info.sys.sunset.ToString())).DateTime.ToShortTimeString();
                    SunriseTextBox.Text = sunriseUTC.ToString();
                    SunsetTextBox.Text = sunsetUTC.ToString();
                    string country = Info.sys.country;
                    CityTextBox.Text = country + ", " + city;
                    string description = DescriptionTextBox.Text = char.ToUpper(Info.weather[0].description[0]) + Info.weather[0].description.Substring(1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                               Give correct city \n    " + ex.Message);
                }
            }
        }

        private void ResetCityBox(object sender, EventArgs e)
        {
            CityTextBox.Text = "";
        }
    }
}
