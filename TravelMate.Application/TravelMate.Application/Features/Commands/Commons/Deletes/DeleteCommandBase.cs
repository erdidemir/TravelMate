using TravelMate.Application.Models.Commons;
using MediatR;

namespace TravelMate.Application.Features.Commands.Commons.Deletes
{
    public class DeleteCommandBase<T> : IRequest<ResponseViewModelBase<NoContent>> where T : class
    {
        public int Id { get; set; }

    }
}
