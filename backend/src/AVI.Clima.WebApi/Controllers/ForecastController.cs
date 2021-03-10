using AVI.Clima.DTOs.Requests.Forecast;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllForecastRequest()));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody] GetForecastRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
