using AutoMapper;
using AVI.Clima.DTOs.Responses.Weather;
using AVI.Clima.Infrastructure.Models;
using System.Collections.Generic;

namespace AVI.Clima.WebApi.Mapper
{
    public class WeatherProfile : Profile
    {
        public WeatherProfile()
        {
            CreateMap<Weather, GetResponse>()
                .ForMember(x => x.TemperatureC, y => y.MapFrom(z => z.Temperature))
                .ForMember(x => x.TemperatureF, y => y.MapFrom(z => ToFahrenheit(z.Temperature)));
            CreateMap<IEnumerable<GetResponse>, GetAllResponse>()
                .ForMember(x => x.Registrys, y => y.MapFrom(z => z));
        }

        private static decimal ToFahrenheit(decimal celsiusTemperature) => (celsiusTemperature * 9) / 5 + 32;
    }
}
