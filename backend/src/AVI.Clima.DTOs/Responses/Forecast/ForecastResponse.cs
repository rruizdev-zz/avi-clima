using System;

namespace AVI.Clima.DTOs.Responses.Forecast
{
    public class ForecastResponse
    {
        public DateTime Date { get; set; }

        public string Status { get; set; }

        public decimal TemperatureC { get; set; }

        public decimal TemperatureF { get; set; }
    }
}
