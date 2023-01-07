using AutoMapper;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Domain.Enums.Commons;
using TravelMate.Domain.Enums.Languages;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Languages.Adds.AddLanguage
{
    public class AddLanguageCommandHandler : IRequestHandler<AddLanguageCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public AddLanguageCommandHandler(IMapper mapper, ILanguageService languageService, ILanguageResourceService languageResourceService)
        {
            _mapper = mapper;
            _languageService = languageService;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<NoContent>> Handle(AddLanguageCommand request, CancellationToken cancellationToken)
        {

            var getEnum = Enum.GetName(typeof(LanguageEnum), request.LanguageEnumId);

            var enumName = EnumHelper<LanguageEnum>.GetDisplayValue(EnumHelper<LanguageEnum>.Parse(getEnum));

            if (getEnum is null || enumName != request.Name)
            {
                var responseMessage1 = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataDoNotMatch, LanguageInfo.Code);

                return ResponseViewModelBase<NoContent>.Fail(responseMessage1, ResultTypeEnum.Error);
            }

            var enumControl = await _languageService.GetFirstAsync(x => x.LanguageEnumId == request.LanguageEnumId);
            if (enumControl is not null)
            {
                var responseMessage2 = await _languageResourceService.GetTranslateAsync(ResponseConstants.AlreadyAvailable, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage2, ResultTypeEnum.Error);
            }

            var languageEntity = _mapper.Map<Language>(request);
            languageEntity.Name = enumName;
            await _languageService.AddAsync(languageEntity);

            var responseMessage3 = await _languageResourceService.GetTranslateAsync(ResponseConstants.AddingWasSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage3, ResultTypeEnum.Success);

        }
    }
}
