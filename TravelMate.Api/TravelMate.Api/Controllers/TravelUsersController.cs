using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TravelMate.Application.Features.Commands.Commons.Updates;
using TravelMate.Application.Features.Commands.Settings.Adds.AddCountry;
using TravelMate.Application.Features.Commands.Travels.Adds;
using TravelMate.Application.Features.Commands.Travels.Updates;
using TravelMate.Application.Features.Queries.Travel.GetTravel;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Travels;
using TravelMate.Domain.Enums.Commons;

namespace TravelMate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TravelUsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TravelUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddTravelUserCommand request)
        {
            var response = await _mediator.Send(request);
            return CreateActionResult(response);
        }

        public IActionResult CreateActionResult<T>(ResponseViewModelBase<T> response)
        {
            if (response.ResultType == ResultTypeEnum.Error)
                return new ObjectResult(response) { StatusCode = 400 };

            return new ObjectResult(response) { StatusCode = 200 };
        }

    }
}
