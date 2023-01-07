using TravelMate.Application.Models.Commons;
using MediatR;

namespace TravelMate.Application.Features.Commands.Languages.Adds.AddLanguage
{
    public class AddLanguageCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int LanguageEnumId { get; set; }
       
    }
}
