using System.Collections.Generic;

namespace AVI.Clima.DTOs.Responses.Weather
{
    public class GetAllResponse
    {
        public IEnumerable<GetResponse> Registrys { get; set; }
    }
}
