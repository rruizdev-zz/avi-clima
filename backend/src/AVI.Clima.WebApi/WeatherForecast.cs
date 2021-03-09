using System;

namespace AVI.Clima.WebApi
{
    public record WeatherForecast
    {
        public DateTime Date { get; init; }

        public int TemperatureC { get; init; }

        public int TemperatureF => Convert.ToInt32(TemperatureC / 0.5556) + 32;

        public int Humidity { get; init; }

        public int RainProbability { get; init; }

        public int Wind { get; init; }

        public string Summary { get; init; }
    }
}
