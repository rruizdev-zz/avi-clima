using AVI.Clima.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AVI.Clima.Infrastructure.Repositories
{
    public static class Dependencies
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IWeatherRepository, WeatherRepository>();
            services.AddScoped<IForecastRepository, ForecastRepository>();
        }
    }
}
