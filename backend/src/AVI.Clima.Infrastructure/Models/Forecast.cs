using System;

namespace AVI.Clima.Infrastructure.Models
{
    public class Forecast
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Status { get; set; }

        public decimal Temperature { get; set; }

        public string Date { get; set; }
    }
}
