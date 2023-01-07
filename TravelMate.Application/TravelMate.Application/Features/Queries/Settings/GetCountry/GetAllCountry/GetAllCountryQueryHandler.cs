using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Features.Queries.Commons.GetAll;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Settings;
using TravelMate.Application.Services.Settings;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Settings.GetCountry.GetAllCountry
{
    public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQuery, ResponseViewModelBase<IReadOnlyList<CountryViewModel>>>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;
        public GetAllCountryQueryHandler(IMapper mapper, ICountryService countryService)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<ResponseViewModelBase<IReadOnlyList<CountryViewModel>>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
        {
            var countryList = await _countryService.GetAllAsync();
            var returnList = _mapper.Map<IReadOnlyList<CountryViewModel>>(countryList);
            return ResponseViewModelBase<IReadOnlyList<CountryViewModel>>.Success(returnList, ResultTypeEnum.Success);
        }
    }
}
