using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Services.Languages;
using FluentValidation;
using TravelMate.Application.Features.Commands.Travels.Adds;

namespace TravelMate.Application.Features.Commands.Travels.Adds.AddTravel
{
    public class AddTravelCommandValidator : AbstractValidator<AddTravelCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;

        public AddTravelCommandValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;

            RuleFor(p => p.ArriveLocationCityName).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.CityIsRequired, LanguageInfo.Code).Result);
            RuleFor(p => p.DepartLocationCityName).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.CityIsRequired, LanguageInfo.Code).Result);

        }
    }
}
