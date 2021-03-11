using AVI.Clima.DTOs.Responses.Weather;
using MediatR;

namespace AVI.Clima.DTOs.Requests.Weather
{
    public class GetRequest : IRequest<GetResponse>
    {
        public int IdCity { get; set; }

        public int IdCountry { get; set; }
    }
}
