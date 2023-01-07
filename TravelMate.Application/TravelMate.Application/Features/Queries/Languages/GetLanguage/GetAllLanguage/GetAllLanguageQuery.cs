using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Languages;
using MediatR;
using System.Collections.Generic;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguage.GetAllLanguage
{
    public class GetAllLanguageQuery : IRequest<ResponseViewModelBase<IReadOnlyList<LanguageViewModel>>>
    {
       
    }
}
