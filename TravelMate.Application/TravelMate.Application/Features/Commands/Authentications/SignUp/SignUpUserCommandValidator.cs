using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Authentications.SignUp
{
    public class SignUpUserCommandValidator : AbstractValidator<SignUpUserCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;
        public SignUpUserCommandValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;
            RuleFor(p => p.FirstName).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.FirstNameIsRequired, LanguageInfo.Code).Result);
            RuleFor(p => p.LastName).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.LastNameIsRequired, LanguageInfo.Code).Result);

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.EmailAddressIsRequired, LanguageInfo.Code).Result)
                .EmailAddress().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.InvalidEmailAddress, LanguageInfo.Code).Result);

            RuleFor(p => p.Password).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.PasswordIsRequired, LanguageInfo.Code).Result)
                .Matches(new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")).WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.PasswordIsInvalid, LanguageInfo.Code).Result); ;
        }
    }
}
