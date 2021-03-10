using AVI.Clima.DTOs.Requests.Weather;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllWeatherRequest()));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody] GetWeatherRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
