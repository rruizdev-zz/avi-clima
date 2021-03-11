using AVI.Clima.DTOs.Requests.Forecast;
using AVI.Clima.Infrastructure.Models;
using AVI.Clima.Infrastructure.Repositories.Interfaces;
using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AVI.Clima.Infrastructure.Repositories
{
    public class ForecastRepository : IForecastRepository
    {
        private readonly IConfiguration _config;

        public ForecastRepository(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<Forecast>> Get(GetRequest request)
        {
            using var connection = new SqliteConnection(_config.GetConnectionString("Database"));

            return await connection.QueryAsync<Forecast>($@"
                SELECT CI.NAME AS CITY, CO.NAME AS COUNTRY, S.NAME AS STATUS, F.CELSIUS_TEMP AS TEMPERATURE, F.DATE
                FROM FORECAST AS F
                INNER JOIN CITY AS CI ON F.ID_CITY = {request.IdCity} AND CI.ID = F.ID_CITY
                INNER JOIN COUNTRY AS CO ON F.ID_COUNTRY = {request.IdCountry} AND CO.ID = F.ID_COUNTRY
                INNER JOIN STATUS AS S ON S.ID = F.ID_STATUS
                ORDER BY F.DATE DESC");
        }

        public async Task<IEnumerable<Forecast>> GetAll()
        {
            using var connection = new SqliteConnection(_config.GetConnectionString("Database"));

            return await connection.QueryAsync<Forecast>($@"
                SELECT CI.NAME AS CITY, CO.NAME AS COUNTRY, S.NAME AS STATUS, F.CELSIUS_TEMP AS TEMPERATURE, F.DATE
                FROM FORECAST AS F
                INNER JOIN CITY AS CI ON CI.ID = F.ID_CITY
                INNER JOIN COUNTRY AS CO ON CO.ID = F.ID_COUNTRY
                INNER JOIN STATUS AS S ON S.ID = F.ID_STATUS
                ORDER BY F.DATE DESC");
        }
    }
}
