﻿namespace WeatherForcast.Models
{
    public class Weather
    {
        public float Id { get; set; }
        public string main { get; set; }

        public string description { get; set; }

        public string icon { get; set; }
    }
}
