using TravelMate.Application.Models.Commons;
using MediatR;
using System.Collections.Generic;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguage.GetEnumLanguage
{
    public class GetEnumLanguageQuery : IRequest<ResponseViewModelBase<IReadOnlyList<BaseEnumViewModel>>>
    {
    }
}
