using AutoMapper;
using MediatR;

using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Travels;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Services.Travels;
using TravelMate.Domain.Enums.Commons;

namespace TravelMate.Application.Features.Queries.Travel.GetTravel
{
    public class GetTravelBySearchQueryHandler : IRequestHandler<GetTravelBySearchQuery, ResponseViewModelBase<IReadOnlyList<TravelViewModel>>>
    {
        private readonly ITravelService _orderService;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;


        public GetTravelBySearchQueryHandler(IMapper mapper, ITravelService orderService, ILanguageResourceService languageResourceService)
        {
            _orderService = orderService;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<IReadOnlyList<TravelViewModel>>> Handle(GetTravelBySearchQuery request, CancellationToken cancellationToken)
        {
            var travelList = await _orderService.GetAsync(p => p.DepartLocation.CityName.Contains(request.DepartCity) ||
            p.ArriveLocation.CityName.Contains(request.ArriveCity) ||
            p.DepartLocation.Name.Contains(request.DepartName) ||
            p.ArriveLocation.Name.Contains(request.ArriveName), x => x.DepartLocation, x => x.ArriveLocation);
            
            if (travelList is null)
            {
                var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<IReadOnlyList<TravelViewModel>>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var returnEntity = _mapper.Map<IReadOnlyList<TravelViewModel>>(travelList);

            return ResponseViewModelBase<IReadOnlyList<TravelViewModel>>.Success(returnEntity, ResultTypeEnum.Success);
        }
    }
}
