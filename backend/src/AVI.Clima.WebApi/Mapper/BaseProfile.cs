using AutoMapper;

namespace AVI.Clima.WebApi.Mapper
{
    public class BaseProfile : Profile
    {
        internal static decimal ToFahrenheit(decimal celsiusTemperature) => (celsiusTemperature * 9) / 5 + 32;
    }
}
