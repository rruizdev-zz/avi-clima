using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AVI.Clima.WebApi.Mapper
{
    public static class Dependencies
    {
        public static void AddMappers(this IServiceCollection services)
        {
            var config = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new WeatherProfile());
                mc.AddProfile(new ForecastProfile());
            });

            services.AddSingleton(config.CreateMapper());
        }
    }
}
