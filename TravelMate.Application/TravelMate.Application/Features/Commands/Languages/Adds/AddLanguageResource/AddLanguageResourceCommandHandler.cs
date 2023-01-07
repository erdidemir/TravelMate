using AutoMapper;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Domain.Enums.Commons;
using TravelMate.Application.Features.Commands.Commons.Adds;

namespace TravelMate.Application.Features.Commands.Languages.Adds.AddLanguageResource
{
    public class AddLanguageResourceCommandHandler : AddCommandBaseHandler<AddLanguageResourceCommand>
    {
        private readonly ILanguageResourceService _languageResourceService;
        private readonly IMapper _mapper;
        private readonly ILanguageService _languageService;

        public AddLanguageResourceCommandHandler(ILanguageResourceService languageResourceService, IMapper mapper, ILanguageService languageService)
        {
            _languageResourceService = languageResourceService;
            _mapper = mapper;
            _languageService = languageService;
        }
        public async override Task<ResponseViewModelBase<NoContent>> Handle(AddCommandBase<AddLanguageResourceCommand> request, CancellationToken cancellationToken)
        {
            var responseMessage = "";
            var checkLanguage = await _languageService.GetFirstAsync(x => x.Code == request.Entity.LanguageCode);
            if (checkLanguage is null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.LanguageNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }
           
            var checkEntity = await _languageResourceService.GetFirstAsync(x => x.LanguageCode == request.Entity.LanguageCode && x.Name == request.Entity.Name && x.Value == request.Entity.Value);

            if (checkEntity is not null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.AlreadyAvailable, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var entity = _mapper.Map<LanguageResource>(request.Entity);
            await _languageResourceService.AddAsync(entity);

            responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.AddingWasSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage, ResultTypeEnum.Success);

        }
    }
}
