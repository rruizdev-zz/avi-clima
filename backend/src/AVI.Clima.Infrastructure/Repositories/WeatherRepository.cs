using AVI.Clima.DTOs.Requests.Weather;
using AVI.Clima.Infrastructure.Models;
using AVI.Clima.Infrastructure.Repositories.Interfaces;
using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AVI.Clima.Infrastructure.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly IConfiguration _config; 
        
        public WeatherRepository(IConfiguration config)
        {
            _config = config;
        }
        
        public async Task<Weather> Get(GetRequest request)
        {
            using var connection = new SqliteConnection(_config.GetConnectionString("Database"));

            return await connection.QueryFirstOrDefaultAsync<Weather>($@"
                SELECT CI.NAME AS CITY, CO.NAME AS COUNTRY, S.NAME AS STATUS, W.CELSIUS_TEMP AS TEMPERATURE, 
                       W.RAIN_PROBABLY AS RAIN, W.HUMIDITY, W.WIND
                FROM WEATHER AS W
                INNER JOIN CITY AS CI ON W.ID_CITY = {request.IdCity} AND CI.ID = W.ID_CITY
                INNER JOIN COUNTRY AS CO ON W.ID_COUNTRY = {request.IdCountry} AND CO.ID = W.ID_COUNTRY
                INNER JOIN STATUS AS S ON S.ID = W.ID_STATUS
                ORDER BY W.ID DESC");
        }

        public async Task<IEnumerable<Weather>> GetAll()
        {
            using var connection = new SqliteConnection(_config.GetConnectionString("Database"));

            return await connection.QueryAsync<Weather>($@"
                SELECT CI.NAME AS CITY, CO.NAME AS COUNTRY, S.NAME AS STATUS, W.CELSIUS_TEMP AS TEMPERATURE, 
                       W.RAIN_PROBABLY AS RAIN, W.HUMIDITY, W.WIND
                FROM WEATHER AS W
                INNER JOIN CITY AS CI ON CI.ID = W.ID_CITY
                INNER JOIN COUNTRY AS CO ON CO.ID = W.ID_COUNTRY
                INNER JOIN STATUS AS S ON S.ID = W.ID_STATUS
                ORDER BY W.ID DESC");
        }
    }
}
