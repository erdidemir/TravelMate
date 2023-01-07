using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Services.Languages;
using FluentValidation;
using TravelMate.Application.Features.Commands.Travels.Adds;

namespace TravelMate.Application.Features.Commands.Travels.Adds.AddTravel
{
    public class AddTravelUserCommandValidator : AbstractValidator<AddTravelUserCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;

        public AddTravelUserCommandValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;

            RuleFor(p => p.TravelId).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.IdIsRequired, LanguageInfo.Code).Result);
            RuleFor(p => p.UserId).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.IdIsRequired, LanguageInfo.Code).Result);

        }
    }
}
