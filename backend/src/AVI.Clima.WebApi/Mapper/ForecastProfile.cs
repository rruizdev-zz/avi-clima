using AVI.Clima.DTOs.Responses.Forecast;
using AVI.Clima.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AVI.Clima.WebApi.Mapper
{
    public class ForecastProfile : BaseProfile
    {
        public ForecastProfile()
        {
            CreateMap<IEnumerable<Forecast>, GetAllResponse>()
                .ForMember(x => x.City, y => y.MapFrom(z => z.FirstOrDefault().City))
                .ForMember(x => x.Country, y => y.MapFrom(z => z.FirstOrDefault().Country))
                .ForMember(x => x.Forecasts, y => y.MapFrom(z => z.Select(forecast => new ForecastResponse()
                {
                    Date = DateTime.ParseExact(forecast.Date, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Status = forecast.Status,
                    TemperatureC = forecast.Temperature,
                    TemperatureF = ToFahrenheit(forecast.Temperature)
                })));
            CreateMap<IEnumerable<Forecast>, GetResponse>()
                .ForMember(x => x.City, y => y.MapFrom(z => z.FirstOrDefault().City))
                .ForMember(x => x.Country, y => y.MapFrom(z => z.FirstOrDefault().Country))
                .ForMember(x => x.Forecasts, y => y.MapFrom(z => z.Select(forecast => new ForecastResponse()
                {
                    Date = DateTime.ParseExact(forecast.Date, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Status = forecast.Status,
                    TemperatureC = forecast.Temperature,
                    TemperatureF = ToFahrenheit(forecast.Temperature)
                })));
        }
    }
}
