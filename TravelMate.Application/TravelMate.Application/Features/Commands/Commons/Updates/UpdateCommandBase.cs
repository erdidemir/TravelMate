using TravelMate.Application.Models.Commons;
using MediatR;

namespace TravelMate.Application.Features.Commands.Commons.Updates
{
    public class UpdateCommandBase<T> : IRequest<ResponseViewModelBase<NoContent>> where T : class
    {
     
        public T Entity { get; set; }
    }
}
