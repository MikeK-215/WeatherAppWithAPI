//using WeatherInfo;
using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherAppWithAPI;

namespace WeatherTest
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Coord_Property_Set_And_Get()
        {
            var coord = new WeatherInfo.coord { lon = 10.5, lat = 20.5 };
            Assert.AreEqual(10.5, coord.lon);
            Assert.AreEqual(20.5, coord.lat);
        }

        [TestMethod]
        public void Weather_Property_Set_And_Get()
        {
            var weather = new WeatherInfo.weather
            {
                main = "Clouds",
                description = "overcast clouds",
                icon = "04d"
            };
            Assert.AreEqual("Clouds", weather.main);
            Assert.AreEqual("overcast clouds", weather.description);
            Assert.AreEqual("04d", weather.icon);
        }

        [TestMethod]
        public void Main_Property_Set_And_Get()
        {
            var main = new WeatherInfo.main
            {
                temp = 300.15,
                feels_like = 299.15,
                temp_min = 295.15,
                temp_max = 305.15,
                pressure = 1013,
                humidity = 80
            };
            Assert.AreEqual(300.15, main.temp);
            Assert.AreEqual(299.15, main.feels_like);
            Assert.AreEqual(295.15, main.temp_min);
            Assert.AreEqual(305.15, main.temp_max);
            Assert.AreEqual(1013, main.pressure);
            Assert.AreEqual(80, main.humidity);
        }

        [TestMethod]
        public void Wind_Property_Set_And_Get()
        {
            var wind = new WeatherInfo.wind { speed = 5.5, deg = 180 };
            Assert.AreEqual(5.5, wind.speed);
            Assert.AreEqual(180, wind.deg);
        }

        [TestMethod]
        public void Sys_Property_Set_And_Get()
        {
            var sys = new WeatherInfo.sys
            {
                type = 1,
                id = 1234,
                country = "US",
                sunrise = 1600000000,
                sunset = 1600040000
            };
            Assert.AreEqual(1, sys.type);
            Assert.AreEqual(1234, sys.id);
            Assert.AreEqual("US", sys.country);
            Assert.AreEqual(1600000000, sys.sunrise);
            Assert.AreEqual(1600040000, sys.sunset);
        }

        [TestMethod]
        public void Root_Deserialization_Works()
        {
            string json = @"
                {
                    ""coord"": { ""lon"": 10.5, ""lat"": 20.5 },
                    ""weather"": [
                        { ""main"": ""Clouds"", ""description"": ""overcast clouds"", ""icon"": ""04d"" }
                    ],
                    ""main"": {
                        ""temp"": 300.15,
                        ""feels_like"": 299.15,
                        ""temp_min"": 295.15,
                        ""temp_max"": 305.15,
                        ""pressure"": 1013,
                        ""humidity"": 80
                    },
                    ""wind"": { ""speed"": 5.5, ""deg"": 180 },
                    ""sys"": { ""type"": 1, ""id"": 1234, ""country"": ""US"", ""sunrise"": 1600000000, ""sunset"": 1600040000 }
                }";
            var root = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

            Assert.IsNotNull(root);
            Assert.AreEqual(10.5, root.coord.lon);
            Assert.AreEqual(20.5, root.coord.lat);
            //Assert.Single(root.weather);
            Assert.AreEqual("Clouds", root.weather[0].main);
            Assert.AreEqual(300.15, root.main.temp);
            Assert.AreEqual(5.5, root.wind.speed);
            Assert.AreEqual("US", root.sys.country);
        }
    }
}
