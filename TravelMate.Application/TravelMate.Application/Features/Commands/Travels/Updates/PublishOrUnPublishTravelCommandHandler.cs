using AutoMapper;
using MediatR;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Features.Commands.Commons.Updates;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Services.Travels;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Domain.Enums.Commons;

namespace TravelMate.Application.Features.Commands.Travels.Updates
{

    public class PublishOrUnPublishTravelCommanddHandler : IRequestHandler<PublishOrUnPublishTravelCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly ITravelService _travelService;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public PublishOrUnPublishTravelCommanddHandler(ITravelService travelService, IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _travelService = travelService ?? throw new ArgumentNullException(nameof(travelService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<NoContent>> Handle(PublishOrUnPublishTravelCommand request, CancellationToken cancellationToken)
        {
            string responseMessage = "";

            var travelToUpdate = await _travelService.GetByIdAsync(request.TravelId);

            if (travelToUpdate == null)
            {
                throw new Exception(request.TravelId.ToString());
            }

            travelToUpdate.IsActive = request.IsActive;

            await _travelService.UpdateAsync(travelToUpdate);

            responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.TransactionSuccessful, LanguageInfo.Code);

            return ResponseViewModelBase<NoContent>.Success(responseMessage, ResultTypeEnum.Success);
        }
    }
}