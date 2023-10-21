using WeatherForcast.ViewModels;

namespace WeatherForcast.Repositories
{
    public interface IWeatherRepository
    {
        WeatherResult GetWeatherData(string CityName);
    }
}
