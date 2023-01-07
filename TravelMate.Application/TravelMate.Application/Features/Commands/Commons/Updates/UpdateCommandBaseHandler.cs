using TravelMate.Application.Models.Commons;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Commons.Updates
{
    public class UpdateCommandBaseHandler<T> : IRequestHandler<UpdateCommandBase<T>, ResponseViewModelBase<NoContent>> where T : class
    {
        public UpdateCommandBaseHandler()
        {
        }

        public virtual async Task<ResponseViewModelBase<NoContent>> Handle(UpdateCommandBase<T> request, CancellationToken cancellationToken)
        {
            return ResponseViewModelBase<NoContent>.Success("Transaction successful.", ResultTypeEnum.Success);
        }
    }
}