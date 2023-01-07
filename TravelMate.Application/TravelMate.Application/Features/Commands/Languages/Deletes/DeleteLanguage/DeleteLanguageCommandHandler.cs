using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Languages.Deletes.DeleteLanguage
{
    public class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly ILanguageService _languageService;
        private readonly ILanguageResourceService _languageResourceService;

        public DeleteLanguageCommandHandler(ILanguageService languageService, ILanguageResourceService languageResourceService)
        {
            _languageService = languageService;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<NoContent>> Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
        {
            var languageEntity = await _languageService.GetByIdAsync(request.Id);
            if (languageEntity is null)
            {
                var responseMessage1 = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage1, ResultTypeEnum.Error);
            }
            languageEntity.IsDeleted = true;
            await _languageService.UpdateAsync(languageEntity);

            var responseMessage2 = await _languageResourceService.GetTranslateAsync(ResponseConstants.DeletingIsSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage2, ResultTypeEnum.Success);

        }
    }
}
