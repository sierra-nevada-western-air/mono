namespace Mono.API.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Application.Airports.GetAllAirports;

    [ApiController]
    [Route("api/[controller]")]
    public class AirportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AirportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("", Name = "GetAllAirports")]
        [ProducesResponseType(typeof(GetAllAirportsResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllAirports()
        {
            var response = await _mediator.Send(new GetAllAirportsRequest());

            return Ok(response);
        }
    }
}
