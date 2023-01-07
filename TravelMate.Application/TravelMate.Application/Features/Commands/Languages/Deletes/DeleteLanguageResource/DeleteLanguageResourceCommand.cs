using TravelMate.Application.Models.Commons;
using MediatR;

namespace TravelMate.Application.Features.Commands.Languages.Deletes.DeleteLanguageResource
{
    public class DeleteLanguageResourceCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
    }
}
