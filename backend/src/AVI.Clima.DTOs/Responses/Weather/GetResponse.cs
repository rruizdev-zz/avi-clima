using System;

namespace AVI.Clima.DTOs.Responses.Weather
{
    public class GetResponse
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Status { get; set; }

        public decimal TemperatureC { get; set; }

        public decimal TemperatureF { get; set; }

        public int Rain { get; set; }

        public int Humidity { get; set; }

        public int Wind { get; set; }
    }
}
