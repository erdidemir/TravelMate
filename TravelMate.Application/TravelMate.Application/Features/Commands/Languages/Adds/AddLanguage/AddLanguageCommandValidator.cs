using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using FluentValidation;

namespace TravelMate.Application.Features.Commands.Languages.Adds.AddLanguage
{
    public class AddLanguageCommandValidator : AbstractValidator<AddLanguageCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;

        public AddLanguageCommandValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService= languageResourceService;
            RuleFor(p => p.Name).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.LanguageIsRequired, LanguageInfo.Code).Result);

            RuleFor(p => p.LanguageEnumId).NotEmpty().WithMessage("Language Enum Id is required.");

        }
    }
}
