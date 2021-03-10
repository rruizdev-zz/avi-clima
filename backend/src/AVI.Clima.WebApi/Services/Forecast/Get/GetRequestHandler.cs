using AVI.Clima.DTOs.Requests.Forecast;
using AVI.Clima.DTOs.Responses.Forecast;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Services.Forecast.Get
{
    public class GetRequestHandler : IRequestHandler<GetRequest, GetResponse>
    {
        public Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
