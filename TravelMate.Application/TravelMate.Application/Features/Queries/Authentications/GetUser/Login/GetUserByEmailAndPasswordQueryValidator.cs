using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using FluentValidation;

namespace TravelMate.Application.Features.Queries.Authentications.GetUser.Login
{
    public class GetUserByEmailAndPasswordQueryValidator:AbstractValidator<GetUserByEmailAndPasswordQuery>
    {
        private readonly ILanguageResourceService _languageResourceService;
        public GetUserByEmailAndPasswordQueryValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;
            RuleFor(p => p.Email).EmailAddress().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.InvalidEmailAddress, LanguageInfo.Code).Result);
            RuleFor(p => p.Password).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.PasswordIsRequired, LanguageInfo.Code).Result);
        }
    }
}
