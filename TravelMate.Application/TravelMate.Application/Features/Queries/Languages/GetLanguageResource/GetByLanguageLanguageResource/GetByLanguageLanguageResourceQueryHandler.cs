using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Languages;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguageResource.GetByLanguageLanguageResource
{
    public class GetByLanguageLanguageResourceQueryHandler : IRequestHandler<GetByLanguageLanguageResourceQuery, ResponseViewModelBase<IReadOnlyList<LanguageResourceViewModel>>>
    {
        private readonly ILanguageResourceService _languageResourceService;
        private readonly IMapper _mapper;

        public GetByLanguageLanguageResourceQueryHandler(IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;
            _mapper = mapper;
        }

        public async Task<ResponseViewModelBase<IReadOnlyList<LanguageResourceViewModel>>> Handle(GetByLanguageLanguageResourceQuery request, CancellationToken cancellationToken)
        {
            var languageResourceEntity = await _languageResourceService.GetAsync(p => p.LanguageCode == LanguageInfo.Code, x => x.Language);
            if (languageResourceEntity is null)
            {
                var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<IReadOnlyList<LanguageResourceViewModel>>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var returnEntity = _mapper.Map<IReadOnlyList<LanguageResourceViewModel>>(languageResourceEntity);

            return ResponseViewModelBase<IReadOnlyList<LanguageResourceViewModel>>.Success(returnEntity, ResultTypeEnum.Success);
        }
    }
}
