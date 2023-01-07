using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Features.Commands.Commons.Deletes;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using TravelMate.Domain.Enums.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Languages.Deletes.DeleteLanguageResource
{
    public class DeleteLanguageResourceCommandHandler : DeleteCommandBaseHandler<DeleteLanguageResourceCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;

        public DeleteLanguageResourceCommandHandler(ILanguageResourceService languageResourceService)
        {
            _languageResourceService = languageResourceService;
        }
        public override async Task<ResponseViewModelBase<NoContent>> Handle(DeleteCommandBase<DeleteLanguageResourceCommand> request, CancellationToken cancellationToken)
        {
            var languageResourceEntity = await _languageResourceService.GetByIdAsync(request.Id);
            if (languageResourceEntity is null)
            {
                var responseMessage1 = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage1, ResultTypeEnum.Error);
            }
            languageResourceEntity.IsDeleted = true;
            await _languageResourceService.UpdateAsync(languageResourceEntity);

            var responseMessage2 = await _languageResourceService.GetTranslateAsync(ResponseConstants.DeletingIsSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage2, ResultTypeEnum.Success);
        }
    }
}
