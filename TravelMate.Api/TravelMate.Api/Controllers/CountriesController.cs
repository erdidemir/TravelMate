using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelMate.Application.Features.Commands.Settings.Adds.AddCountry;
using TravelMate.Application.Features.Commands.Settings.Deletes.DeleteCountry;
using TravelMate.Application.Features.Queries.Settings.GetCountry.GetAllCountry;
using TravelMate.Application.Features.Queries.Settings.GetCountry.GetByCodeCountry;
using TravelMate.Application.Features.Queries.Settings.GetCountry.GetEnumCountry;
using TravelMate.Application.Features.Queries.Settings.GetCountry.GetNameAndPhoneCodeCountry;
using TravelMate.Application.Models.Commons;
using TravelMate.Domain.Enums.Commons;

namespace TravelMate.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class CountriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CountriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("Enum")]
        public async Task<IActionResult> GetEnum()
        {
            var result = await _mediator.Send(new GetEnumCountryQuery());
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllCountryQuery());
            return CreateActionResult(response);
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetByCode(string code)
        {
            var response = await _mediator.Send(new GetByCodeCountryQuery() { Code = code });
            return CreateActionResult(response);
        }
        [HttpGet("NameAndPhoneCode")]
        public async Task<IActionResult> GetNameAndPhoneCode()
        {
            var result = await _mediator.Send(new GetNameAndPhoneCodeCountryQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCountryCommand request)
        {
            var response = await _mediator.Send(request);
            return CreateActionResult(response);

        }

        [HttpDelete("{code}")]
        public async Task<IActionResult> Update(string code)
        {
            var response = await _mediator.Send(new DeleteCountryCommand { Code = code });
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
