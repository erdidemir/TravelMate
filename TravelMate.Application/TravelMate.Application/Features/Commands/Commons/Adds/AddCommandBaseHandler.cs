using TravelMate.Application.Models.Commons;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Commons.Adds
{
    public class AddCommandBaseHandler<T> : IRequestHandler<AddCommandBase<T>, ResponseViewModelBase<NoContent>> where T : class
    {
        public AddCommandBaseHandler()
        {
        }

        public virtual async Task<ResponseViewModelBase<NoContent>> Handle(AddCommandBase<T> request, CancellationToken cancellationToken)
        {
            return ResponseViewModelBase<NoContent>.Success("Transaction successful.", ResultTypeEnum.Success);
        }
    }
}
