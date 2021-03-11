using System;

namespace AVI.Clima.Infrastructure.Models
{
    public class Weather
    {
        public string City { get; set; }

        public string Country { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }

        public decimal Temperature { get; set; }

        public int Rain { get; set; }

        public int Humidity { get; set; }

        public int Wind { get; set; }
    }
}
