using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Settings;
using TravelMate.Application.Services.Settings;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Settings.GetCountry.GetNameAndPhoneCodeCountry
{
    public class GetNameAndPhoneCodeCountryQueryHandler : IRequestHandler<GetNameAndPhoneCodeCountryQuery, ResponseViewModelBase<IReadOnlyList<CountryNameAndPhoneCodeViewModel>>>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;
        public GetNameAndPhoneCodeCountryQueryHandler(IMapper mapper, ICountryService countryService)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<ResponseViewModelBase<IReadOnlyList<CountryNameAndPhoneCodeViewModel>>> Handle(GetNameAndPhoneCodeCountryQuery request, CancellationToken cancellationToken)
        {
            var countryList = await _countryService.GetAllAsync();
            var returnList = _mapper.Map<IReadOnlyList<CountryNameAndPhoneCodeViewModel>>(countryList);
            return ResponseViewModelBase<IReadOnlyList<CountryNameAndPhoneCodeViewModel>>.Success(returnList, ResultTypeEnum.Success);
        }
    }
}