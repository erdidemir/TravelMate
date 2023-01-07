using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelMate.Application.Features.Commands.Commons.Adds;
using TravelMate.Application.Features.Commands.Commons.Deletes;
using TravelMate.Application.Features.Commands.Commons.Updates;
using TravelMate.Application.Features.Queries.Commons.GetAll;
using TravelMate.Application.Features.Queries.Commons.GetById;
using TravelMate.Application.Models.Commons;
using TravelMate.Domain.Enums.Commons;

namespace TravelMate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomControllerBase<R, C, U, D> : ControllerBase
         where R : class
         where C : class
         where U : class
         where D : class
    {
        private readonly IMediator _mediator;

        public CustomControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllQuery<R>());
            return CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _mediator.Send(new GetByIdQuery<R>() { Id = id });
            return CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCommandBase<C> request)
        {
            var response = await _mediator.Send(new AddCommandBase<C>() { Entity = request.Entity });
            return CreateActionResult(response);

        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCommandBase<U> request)
        {
            var response = await _mediator.Send(new UpdateCommandBase<U>() { Entity = request.Entity });
            return CreateActionResult(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteCommandBase<D> { Id = id });
            return CreateActionResult(response);
        }

        [NonAction]
        public IActionResult CreateActionResult<T>(ResponseViewModelBase<T> response)
        {
            if (response.ResultType == ResultTypeEnum.Error)
                return new ObjectResult(response) { StatusCode = 400 };

            return new ObjectResult(response) { StatusCode = 200 };
        }
    }
}
