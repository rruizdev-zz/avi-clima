using AutoMapper;
using AVI.Clima.DTOs.Requests.Forecast;
using AVI.Clima.DTOs.Responses.Forecast;
using AVI.Clima.Infrastructure.Repositories.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Services.Forecast.GetAll
{
    public class GetAllRequestHandler : IRequestHandler<GetAllRequest, GetAllResponse>
    {
        private readonly IForecastRepository _repository;
        private readonly IMapper _mapper;

        public GetAllRequestHandler(IForecastRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAllResponse> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            var forecasts = await _repository.GetAll();

            return _mapper.Map<GetAllResponse>(forecasts);
        }
    }
}
