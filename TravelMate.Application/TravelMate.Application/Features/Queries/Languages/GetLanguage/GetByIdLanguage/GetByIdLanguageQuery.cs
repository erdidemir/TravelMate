using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Languages;
using MediatR;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguage.GetByIdLanguage
{
    public class GetByIdLanguageQuery : IRequest<ResponseViewModelBase<LanguageViewModel>>
    {
       
        public int Id { get; set; }
    }
}
