using AVI.Clima.DTOs.Requests.Weather;
using AVI.Clima.DTOs.Responses.Weather;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Services.Weather.Get
{
    public class GetRequestHandler : IRequestHandler<GetRequest, GetResponse>
    {
        public Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
