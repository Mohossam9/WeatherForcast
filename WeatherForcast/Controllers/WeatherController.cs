using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherForcast.Models;
using WeatherForcast.Repositories;

namespace WeatherForcast.Controllers
{
    public class WeatherController : Controller
    {

        IWeatherRepository weatherRepository;
        public WeatherController(IWeatherRepository _weatherRepository)
        {
            weatherRepository= _weatherRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SearchBy city)
        {
            if (ModelState.IsValid)
            {
                var WeatherData = weatherRepository.GetWeatherData(city.Name);
                if (WeatherData == null)
                {
                    ModelState.AddModelError("", "Invalid Name No Matching");
                    return View(city);
                }
                var newcity = new City
                {
                    Name = WeatherData.name,
                    Humidity = WeatherData.main.humidity,
                    Pressure = WeatherData.main.pressure,
                    Temperature = WeatherData.main.temp,
                    Weather = WeatherData.weather[0].main ?? "Unknown",
                    Wind = WeatherData.wind.speed,
                    TempMax = WeatherData.main.temp_max,
                    TempMin = WeatherData.main.temp_min,
                    Feels_Like = WeatherData.main.feels_like
                };
                ViewBag.Data = newcity;
                return View();
            }
           return View(city);
        }

    }
}