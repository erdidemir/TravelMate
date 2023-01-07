using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Features.Commands.Commons.Updates;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Languages.Updates.UpdateLanguageResource
{
    public class UpdateLanguageResourceCommandValidator : AbstractValidator<UpdateCommandBase<UpdateLanguageResourceCommand>>
    {
        private readonly ILanguageResourceService _languageResourceService;

        public UpdateLanguageResourceCommandValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;
            RuleFor(p => p.Entity.LanguageCode).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.LanguageCodeIsRequired, LanguageInfo.Code).Result);

            RuleFor(p => p.Entity.Name).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.LanguageIsRequired, LanguageInfo.Code).Result);

            RuleFor(p => p.Entity.Value).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.ValueIsRequired, LanguageInfo.Code).Result);

        }

    }
}
