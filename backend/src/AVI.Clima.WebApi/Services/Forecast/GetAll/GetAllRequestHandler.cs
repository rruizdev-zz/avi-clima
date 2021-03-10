using AVI.Clima.DTOs.Requests.Forecast;
using AVI.Clima.DTOs.Responses.Forecast;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Services.Forecast.GetAll
{
    public class GetAllRequestHandler : IRequestHandler<GetAllRequest, GetAllResponse>
    {
        public Task<GetAllResponse> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
