using AVI.Clima.DTOs.Requests.Forecast;
using AVI.Clima.Infrastructure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AVI.Clima.Infrastructure.Repositories.Interfaces
{
    public interface IForecastRepository
    {
        Task<IEnumerable<Forecast>> Get(GetRequest request);

        Task<IEnumerable<Forecast>> GetAll();
    }
}
