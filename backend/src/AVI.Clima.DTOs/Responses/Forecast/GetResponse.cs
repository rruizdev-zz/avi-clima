using System.Collections.Generic;

namespace AVI.Clima.DTOs.Responses.Forecast
{
    public class GetResponse
    {
        public string City { get; set; }

        public string Country { get; set; }

        public IEnumerable<ForecastResponse> Forecasts { get; set; }
    }
}
