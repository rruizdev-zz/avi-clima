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
        private readonly ILogger _logger;

        public WeatherController(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllRequest()));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody] GetRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
