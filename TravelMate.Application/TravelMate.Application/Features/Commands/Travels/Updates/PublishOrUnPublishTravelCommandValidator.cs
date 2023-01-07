using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Features.Commands.Commons.Updates;
using TravelMate.Application.Services.Languages;

namespace TravelMate.Application.Features.Commands.Travels.Updates
{
    public class PublishOrUnPublishTravelCommandValidator : AbstractValidator<UpdateCommandBase<PublishOrUnPublishTravelCommand>>
    {
        private readonly ILanguageResourceService _languageResourceService;

        public PublishOrUnPublishTravelCommandValidator(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;

            RuleFor(p => p.Entity.TravelId).NotEmpty().WithMessage(_languageResourceService.GetTranslateAsync(ResponseConstants.IdIsRequired, LanguageInfo.Code).Result);

        }

    }
}
