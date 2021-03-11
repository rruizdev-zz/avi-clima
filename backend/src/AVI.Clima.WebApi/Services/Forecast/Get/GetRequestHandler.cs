using AutoMapper;
using AVI.Clima.DTOs.Requests.Forecast;
using AVI.Clima.DTOs.Responses.Forecast;
using AVI.Clima.Infrastructure.Repositories.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Services.Forecast.Get
{
    public class GetRequestHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly IForecastRepository _repository;
        private readonly IMapper _mapper;

        public GetRequestHandler(IForecastRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var forecasts = await _repository.GetAll();

            return _mapper.Map<GetResponse>(forecasts);
        }
    }
}
