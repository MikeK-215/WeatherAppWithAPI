using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherAppWithAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await getWeatherAsync();
        }

        string APIKey = "45653f79d0a987e201b18d84f70a775c";

        async Task getWeatherAsync()
        {
            try
            {
                using (HttpClient web = new HttpClient())
                {
                    // Making the API call
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                    string json = await web.GetStringAsync(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    // Displaying the weather information
                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labCondition.Text = Info.weather[0].main;
                    labDetail.Text = Info.weather[0].description;
                    labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                    labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                    labWindSpeed.Text = Info.wind.speed.ToString();
                    labPressure.Text = Info.main.pressure.ToString();

                    // Convert temperatures to Fahrenheit
                    labTemp.Text = ConvertToFahrenheit(Info.main.temp).ToString("F1") + " °F";
                    labFeelsLike.Text = ConvertToFahrenheit(Info.main.feels_like).ToString("F1") + " °F";
                    labMaxTemp.Text = ConvertToFahrenheit(Info.main.temp_max).ToString("F1") + " °F";
                    labMinTemp.Text = ConvertToFahrenheit(Info.main.temp_min).ToString("F1") + " °F";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }

        double ConvertToFahrenheit(double kelvin)
        {
            return (kelvin - 273.15) * 9 / 5 + 32;
        }
    }


}
