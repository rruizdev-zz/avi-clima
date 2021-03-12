using AVI.Clima.DTOs.Requests.Forecast;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForecastController : BaseController<ForecastController>
    {
        public ForecastController(IMediator mediator, ILogger<ForecastController> logger): base(mediator, logger)
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
