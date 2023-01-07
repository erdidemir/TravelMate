using AutoMapper;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Services.Settings;
using TravelMate.Domain.Entities.Settings;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using TravelMate.Domain.Enums.Settings;

namespace TravelMate.Application.Features.Commands.Settings.Adds.AddCountry
{
    public class AddCountryCommandHandler : IRequestHandler<AddCountryCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public AddCountryCommandHandler(ICountryService countryService, IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _countryService = countryService;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }
        public async Task<ResponseViewModelBase<NoContent>> Handle(AddCountryCommand request, CancellationToken cancellationToken)
        {
            var getEnum = CountryEnum.GetEnum(request.Name);

            if (request.CountryEnumId == 0 || ((int)getEnum) != request.CountryEnumId)
            {
                var responseMessage1 = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataDoNotMatch, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage1, ResultTypeEnum.Error);
            }

            var enumControl = await _countryService.GetFirstAsync(x => x.CountryEnumId == request.CountryEnumId);
            if (enumControl is not null)
            {
                var responseMessage2 = await _languageResourceService.GetTranslateAsync(ResponseConstants.AlreadyAvailable, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage2, ResultTypeEnum.Error);
            }

            var countryEntity = _mapper.Map<Country>(request);

            countryEntity.Name = CountryEnum.GetCountryName(getEnum);
            countryEntity.Code = CountryEnum.GetCountryCode(getEnum);    
            countryEntity.PhoneCode = CountryEnum.GetPhoneCode(getEnum);

            await _countryService.AddAsync(countryEntity);

            var responseMessage3 = await _languageResourceService.GetTranslateAsync(ResponseConstants.AddingWasSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage3, ResultTypeEnum.Success);
        }
    }
}
