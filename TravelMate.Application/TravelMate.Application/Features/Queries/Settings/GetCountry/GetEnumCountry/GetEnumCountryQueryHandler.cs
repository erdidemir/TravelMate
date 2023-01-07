using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Features.Queries.Commons.GetAll;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Settings;
using TravelMate.Application.Services.Commons;
using TravelMate.Domain.Enums;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using TravelMate.Domain.Enums.Settings;

namespace TravelMate.Application.Features.Queries.Settings.GetCountry.GetEnumCountry
{
    public class GetEnumCountryQueryHandler : IRequestHandler<GetEnumCountryQuery, ResponseViewModelBase<IReadOnlyList<BaseEnumViewModel>>>
    {
        private readonly IMapper _mapper;

        public GetEnumCountryQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ResponseViewModelBase<IReadOnlyList<BaseEnumViewModel>>> Handle(GetEnumCountryQuery request, CancellationToken cancellationToken)
        {
            var countryList = EnumHelper<CountryEnum.Countries>.GetDisplayValues();
            var result = _mapper.Map<IReadOnlyList<BaseEnumViewModel>>(countryList);
            return ResponseViewModelBase<IReadOnlyList<BaseEnumViewModel>>.Success(result, ResultTypeEnum.Success);
        }
    }
}
