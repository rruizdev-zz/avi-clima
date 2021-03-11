using AVI.Clima.DTOs.Requests.Weather;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(IMediator mediator, ILogger<WeatherController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllRequest()));
        }

        [HttpGet("{idCountry}/{idCity}")]
        public async Task<IActionResult> Get([FromRoute] int idCountry, [FromRoute] int idCity)
        {
            return Ok(await _mediator.Send(new GetRequest(idCountry, idCity)));
        }
    }
}
