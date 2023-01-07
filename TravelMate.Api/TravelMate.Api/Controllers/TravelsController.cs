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

    public class TravelsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TravelsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddTravelCommand request)
        {
            //Token kullanıldığında Token Üzerinden UserId alınarak kontrol edilebilir
            //var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var response = await _mediator.Send(request);
            return CreateActionResult(response);

        }

        [HttpPut("publish")]
        public async Task<IActionResult> StockingOrderUnitLoadCell(PublishOrUnPublishTravelCommand request)
        {
            var response = await _mediator.Send(request);
            return CreateActionResult(response);
        }


        [HttpGet("search")]
        public async Task<IActionResult> SearchTravel([FromQuery] GetTravelBySearchQuery query)
        {
            var response = await _mediator.Send(query);
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
