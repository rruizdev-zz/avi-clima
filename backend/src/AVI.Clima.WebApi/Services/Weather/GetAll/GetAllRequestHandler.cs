using AutoMapper;
using AVI.Clima.DTOs.Requests.Weather;
using AVI.Clima.DTOs.Responses.Weather;
using AVI.Clima.Infrastructure.Repositories.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Services.Weather.GetAll
{
    public class GetAllRequestHandler : IRequestHandler<GetAllRequest, GetAllResponse>
    {
        private readonly IWeatherRepository _repository;
        private readonly IMapper _mapper;

        public GetAllRequestHandler(IWeatherRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAllResponse> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            var currentsWeather = await _repository.GetAll();

            return _mapper.Map<GetAllResponse>(currentsWeather.Select(_mapper.Map<GetResponse>));
        }
    }
}
