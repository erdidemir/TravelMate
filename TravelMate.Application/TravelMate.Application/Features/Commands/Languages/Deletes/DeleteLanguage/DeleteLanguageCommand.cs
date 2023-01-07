using TravelMate.Application.Models.Commons;
using MediatR;

namespace TravelMate.Application.Features.Commands.Languages.Deletes.DeleteLanguage
{
    public class DeleteLanguageCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public int Id { get; set; }
       
    }
}
