using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Features.Queries.Commons.GetById;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Languages;
using TravelMate.Application.Services.Languages;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguageResource.GetByIdLanguageResource
{
    public class GetByIdLanguageResourceQueryHandler : GetByIdQueryHandler<LanguageResourceViewModel>
    {
        private readonly ILanguageResourceService _languageResourceService;
        public GetByIdLanguageResourceQueryHandler(IMapper mapper, ILanguageResourceService languageResourceService) : base(mapper,languageResourceService)
        {
            _languageResourceService = languageResourceService;
        }
        public override async Task<ResponseViewModelBase<LanguageResourceViewModel>> Handle(GetByIdQuery<LanguageResourceViewModel> request, CancellationToken cancellationToken)
        {
            _baseEntity = await _languageResourceService.GetFirstAsync(x => x.Id == request.Id,x=>x.Language);
            return await base.Handle(request, cancellationToken);
        }
    }
}
