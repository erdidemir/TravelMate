using AutoMapper;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using TravelMate.Application.Services.Travels;
using TravelMate.Domain.Entities.Travels;

namespace TravelMate.Application.Features.Commands.Travels.Adds.AddTravel
{
    public class AddTravelUserCommandHandler : IRequestHandler<AddTravelUserCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly ITravelUserService _travelUserService;
        private readonly ITravelService _travelService;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public AddTravelUserCommandHandler(ITravelUserService travelUserService, IMapper mapper, ILanguageResourceService languageResourceService,
         ITravelService travelService)
        {
            _travelUserService = travelUserService;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
            _travelService = travelService;
    }
        public async Task<ResponseViewModelBase<NoContent>> Handle(AddTravelUserCommand request, CancellationToken cancellationToken)
        {

            var travelEntity = _travelService.GetByIdAsync(request.TravelId).Result;
            
            var count = _travelUserService.GetAsync(p => p.TravelId == request.TravelId).Result.Count;

            if(travelEntity.SeatingCapacity > count)
            {
                var travelUserEntity = _mapper.Map<TravelUser>(request);

                await _travelUserService.AddAsync(travelUserEntity);
            }
            else
            {
                var errorMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.TransactionFailed, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Success(errorMessage, ResultTypeEnum.Error);
            }

            var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.AddingWasSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage, ResultTypeEnum.Success);
        }
    }
}
