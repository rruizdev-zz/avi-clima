using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AVI.Clima.WebApi.Controllers
{
    public class BaseController<T> : ControllerBase
    {
        protected readonly IMediator _mediator;
        protected readonly ILogger<T> _logger;

        public BaseController(IMediator mediator, ILogger<T> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }


        protected async Task<IActionResult> ValidateRequest(Func<Task<T>> function)
        {
            try
            {
                return Ok(await function.Invoke());
            } 
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
