using AVI.Clima.DTOs.Responses.Weather;
using MediatR;

namespace AVI.Clima.DTOs.Requests.Weather
{
    public record GetRequest(int IdCity, int IdCountry) : IRequest<GetResponse>;
}
