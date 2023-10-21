using WeatherForcast.Models;

namespace WeatherForcast.ViewModels
{
    public class WeatherResult
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public main main { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Cloud clouds { get; set; }
        public Sys sys { get; set; }

        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int code { get; set; }







    }
}
