using AutoMapper;
using AVI.Clima.DTOs.Responses.Weather;
using AVI.Clima.Infrastructure.Models;

namespace AVI.Clima.WebApi.Mapper
{
    public class WeatherProfile : Profile
    {
        public WeatherProfile()
        {
            CreateMap<Weather, GetResponse>()
                .ForMember(x => x.TemperatureF, y => y.MapFrom(z => (z.Temperature * 9) / 5 + 32));
        }
    }
}
