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
    public class AddTravelCommandHandler : IRequestHandler<AddTravelCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly ILocationService _locationService;
        private readonly ITravelService _travelService;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public AddTravelCommandHandler(ITravelService travelService, IMapper mapper, ILanguageResourceService languageResourceService, ILocationService locationService) 
        {
            _travelService = travelService;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
            _locationService = locationService;
        }
        public async Task<ResponseViewModelBase<NoContent>> Handle(AddTravelCommand request, CancellationToken cancellationToken)
        {

            #region DepartLocation

            Location departLocation = new Location();

            departLocation.Name = request.DepartLocationName;
            departLocation.CityName = request.DepartLocationCityName;
            departLocation.Longitude = request.DepartLocationLongitude;
            departLocation.Latitude = request.DepartLocationLatitude;
            departLocation.IsIn = false;

            if (departLocation.Longitude.HasValue && departLocation.Latitude.HasValue)
            {
                //CheckIsIn
                //departLocation.IsIn = true
            }

            await _locationService.AddAsync(departLocation);

            #endregion

            #region DepartLocation

            Location arriveLocation = new Location();

            arriveLocation.Name = request.DepartLocationName;
            arriveLocation.CityName = request.DepartLocationCityName;
            arriveLocation.Longitude = request.DepartLocationLongitude;
            arriveLocation.Latitude = request.DepartLocationLatitude;
            arriveLocation.IsIn = false;

            if (arriveLocation.Longitude.HasValue && arriveLocation.Latitude.HasValue)
            {
                //CheckIsIn
                //arriveLocation.IsIn = true
            }

            await _locationService.AddAsync(arriveLocation);

            #endregion

            var travelEntity = _mapper.Map<Travel>(request);

            travelEntity.DepartLocationId = departLocation.Id;
            travelEntity.ArriveLocationId = arriveLocation.Id;

            await _travelService.AddAsync(travelEntity);

            var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.AddingWasSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage, ResultTypeEnum.Success);
        }
    }
}
