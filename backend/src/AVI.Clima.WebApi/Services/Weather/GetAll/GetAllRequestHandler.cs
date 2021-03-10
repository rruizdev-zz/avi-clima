using AVI.Clima.DTOs.Requests.Weather;
using AVI.Clima.DTOs.Responses.Weather;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Services.Weather.GetAll
{
    public class GetAllRequestHandler : IRequestHandler<GetAllRequest, GetAllResponse>
    {
        public Task<GetAllResponse> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
