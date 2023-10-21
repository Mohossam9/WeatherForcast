using WeatherForcast.ViewModels;
using WeatherForcast.Configurations;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace WeatherForcast.Repositories
{
    public class WeatherRepository:IWeatherRepository
    {
        public WeatherResult GetWeatherData(string CityName)
        {
            var APP_ID = WeatherID.WEAHTER_ID;
            var URLAPI = $"https://api.openweathermap.org/data/2.5/weather?q={CityName}&appid={APP_ID}";

            var Request = new RestRequest(URLAPI,Method.Get);
            var Response = new RestClient(URLAPI).Execute(Request);

            if (!Response.IsSuccessful)
                return null;
           
            return JsonConvert.DeserializeObject<JToken>(Response.Content)?.ToObject<WeatherResult>();
        }

    }
}
