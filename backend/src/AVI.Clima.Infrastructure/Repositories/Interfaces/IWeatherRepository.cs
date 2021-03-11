using AVI.Clima.DTOs.Requests.Weather;
using AVI.Clima.Infrastructure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AVI.Clima.Infrastructure.Repositories.Interfaces
{
    public interface IWeatherRepository
    {
        Task<Weather> Get(GetRequest request);

        Task<IEnumerable<Weather>> GetAll();
    }
}
