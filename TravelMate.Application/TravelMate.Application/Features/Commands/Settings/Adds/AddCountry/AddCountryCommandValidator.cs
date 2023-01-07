using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Settings.Adds.AddCountry
{
    public class AddCountryCommandValidator : AbstractValidator<AddCountryCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;

        public AddCountryCommandValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;

            RuleFor(p => p.Name).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.CountryNameIsRequired, LanguageInfo.Code).Result);
            RuleFor(p => p.CountryEnumId).NotEmpty().WithMessage("Country Enum Id is required.");

        }
    }
}
