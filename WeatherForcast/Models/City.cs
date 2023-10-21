using System.ComponentModel.DataAnnotations;

namespace WeatherForcast.Models
{
    public class City
    {
        [Display(Name ="City Name:")]
        public string Name { get; set; }

        [Display(Name = "Temperature:")]
        public float Temperature { get; set; }

        [Display(Name = "Humidity:")]
        public int Humidity { get; set; }

        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }

        [Display(Name = "Wind Speed:")]
        public float Wind { get; set; }

        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }

        [Display(Name = "Max:")]
        public float TempMax { get; set; }

        [Display(Name = "Min:")]
        public float TempMin { get; set; }

        [Display(Name = "Feels Like:")]
        public float Feels_Like { get; set; }
    }

}
