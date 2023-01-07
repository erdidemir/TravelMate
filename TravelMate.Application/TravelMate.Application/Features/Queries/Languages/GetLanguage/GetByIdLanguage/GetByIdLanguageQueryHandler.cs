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

namespace TravelMate.Application.Features.Queries.Languages.GetLanguage.GetByIdLanguage
{
    public class GetByIdLanguageQueryHandler : IRequestHandler<GetByIdLanguageQuery, ResponseViewModelBase<LanguageViewModel>>
    {
        private readonly ILanguageService _stateService;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public GetByIdLanguageQueryHandler(IMapper mapper, ILanguageService stateService, ILanguageResourceService languageResourceService)
        {
            _stateService = stateService;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }
        public async Task<ResponseViewModelBase<LanguageViewModel>> Handle(GetByIdLanguageQuery request, CancellationToken cancellationToken)
        {
            var stateEntity = await _stateService.GetByIdAsync(request.Id);
            if (stateEntity is null)
            {
                var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);

                return ResponseViewModelBase<LanguageViewModel>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var returnEntity = _mapper.Map<LanguageViewModel>(stateEntity);

            return ResponseViewModelBase<LanguageViewModel>.Success(returnEntity, ResultTypeEnum.Success);
        }
    }
}
