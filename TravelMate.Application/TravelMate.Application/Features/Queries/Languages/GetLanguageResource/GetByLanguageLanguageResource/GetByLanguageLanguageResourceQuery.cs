using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Languages;
using MediatR;
using System.Collections.Generic;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguageResource.GetByLanguageLanguageResource
{
    public class GetByLanguageLanguageResourceQuery : IRequest<ResponseViewModelBase<IReadOnlyList<LanguageResourceViewModel>>>
    {
       
    }
}
