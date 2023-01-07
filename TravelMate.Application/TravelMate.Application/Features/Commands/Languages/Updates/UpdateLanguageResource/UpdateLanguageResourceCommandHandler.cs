using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Features.Commands.Commons.Updates;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Domain.Enums.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Languages.Updates.UpdateLanguageResource
{
    public class UpdateLanguageResourceCommandHandler : UpdateCommandBaseHandler<UpdateLanguageResourceCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;
        private readonly IMapper _mapper;
        private readonly ILanguageService _languageService;
        public UpdateLanguageResourceCommandHandler(IMapper mapper, ILanguageResourceService languageResourceService, ILanguageService languageService) : base()
        {
            _mapper = mapper;
            _languageResourceService = languageResourceService;
            _languageService = languageService;
        }

        public override async Task<ResponseViewModelBase<NoContent>> Handle(UpdateCommandBase<UpdateLanguageResourceCommand> request, CancellationToken cancellationToken)
        {
            var responseMessage = "";
            var checkLanguage = await _languageService.GetFirstAsync(x => x.Code == request.Entity.LanguageCode);
            if (checkLanguage is null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.LanguageNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }

            var languageResourceEntity = await _languageResourceService.GetByIdAsync(request.Entity.Id);

            if (languageResourceEntity is null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var checkEntity = await _languageResourceService.GetFirstAsync(x => x.LanguageCode == request.Entity.LanguageCode && x.Name == request.Entity.Name && x.Value == request.Entity.Value);
            if (checkEntity is not null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.AlreadyAvailable, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            _mapper.Map(request.Entity, languageResourceEntity, typeof(UpdateLanguageResourceCommand), typeof(LanguageResource));

            await _languageResourceService.UpdateAsync(languageResourceEntity);

            responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.UpdateSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage, ResultTypeEnum.Success);
        }
    }
}
