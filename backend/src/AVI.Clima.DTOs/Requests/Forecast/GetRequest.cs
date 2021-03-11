using AVI.Clima.DTOs.Responses.Forecast;
using MediatR;

namespace AVI.Clima.DTOs.Requests.Forecast
{
    public record GetRequest(int IdCountry, int IdCity) : IRequest<GetResponse>;
}
