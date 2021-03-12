using AVI.Clima.DTOs.Requests.Weather;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : BaseController<WeatherController>
    {
        public WeatherController(IMediator mediator, ILogger<WeatherController> logger) : base(mediator, logger)
        {
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
