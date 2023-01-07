using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Features.Queries.Commons.GetAll;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Languages;
using TravelMate.Application.Services.Languages;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguageResource.GetAllLanguageResource
{
    public class GetAllLanguageResourceQueryHandler : GetAllQueryHandler<LanguageResourceViewModel>
    {

        public GetAllLanguageResourceQueryHandler(IMapper mapper, ILanguageResourceService languageResourceService) : base(mapper,languageResourceService)
        {
        }
        public override async Task<ResponseViewModelBase<IReadOnlyList<LanguageResourceViewModel>>> Handle(GetAllQuery<LanguageResourceViewModel> request, CancellationToken cancellationToken)
        {
            _baseEntities = await _languageResourceService.GetAsync(predicate: null, x=>x.Language);
            return await base.Handle(request, cancellationToken);
        }
    }
}
