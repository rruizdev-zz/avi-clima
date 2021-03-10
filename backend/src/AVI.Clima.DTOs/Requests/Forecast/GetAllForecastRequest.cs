using AVI.Clima.DTOs.Responses.Forecast;
using MediatR;

namespace AVI.Clima.DTOs.Requests.Forecast
{
    public class GetAllForecastRequest : IRequest<GetAllForecastResponse>
    {
    }
}
