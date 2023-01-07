using AutoMapper;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Languages;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguage.GetAllLanguage
{
    public class GetAllLanguageQueryHandler : IRequestHandler<GetAllLanguageQuery, ResponseViewModelBase<IReadOnlyList<LanguageViewModel>>>
    {
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public GetAllLanguageQueryHandler(IMapper mapper, ILanguageService languageService, ILanguageResourceService languageResourceService)
        {
            _languageService = languageService;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<IReadOnlyList<LanguageViewModel>>> Handle(GetAllLanguageQuery request, CancellationToken cancellationToken)
        {
            var languageList = await _languageService.GetAllAsync();
            if (languageList is null)
            {
                var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<IReadOnlyList<LanguageViewModel>>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var returnList = _mapper.Map<IReadOnlyList<LanguageViewModel>>(languageList);

            return ResponseViewModelBase<IReadOnlyList<LanguageViewModel>>.Success(returnList, ResultTypeEnum.Success);
        }
    }
}
