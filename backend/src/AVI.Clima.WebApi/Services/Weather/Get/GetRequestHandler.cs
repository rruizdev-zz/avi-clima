using AutoMapper;
using AVI.Clima.DTOs.Requests.Weather;
using AVI.Clima.DTOs.Responses.Weather;
using AVI.Clima.Infrastructure.Repositories.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Services.Weather.Get
{
    public class GetRequestHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly IWeatherRepository _repository;
        private readonly IMapper _mapper;

        public GetRequestHandler(IWeatherRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var currentWeather = await _repository.Get(request);

            return _mapper.Map<GetResponse>(currentWeather);
        }
    }
}
