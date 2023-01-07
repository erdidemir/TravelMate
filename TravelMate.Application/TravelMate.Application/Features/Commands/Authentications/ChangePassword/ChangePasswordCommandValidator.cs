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

namespace TravelMate.Application.Features.Commands.Authentications.ChangePassword
{
    public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;
        public ChangePasswordCommandValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;

            RuleFor(p => p.NewPassword).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.NewPasswordIsRequired, LanguageInfo.Code).Result)
                .MinimumLength(8).WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.PasswordMinimum8Character, LanguageInfo.Code).Result)
                 .Matches(new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$"))
                 .WithMessage(languageResourceService.GetTranslateAsync(ResponseConstants.PasswordIsInvalid, LanguageInfo.Code).Result);
            
        }
    }
}
