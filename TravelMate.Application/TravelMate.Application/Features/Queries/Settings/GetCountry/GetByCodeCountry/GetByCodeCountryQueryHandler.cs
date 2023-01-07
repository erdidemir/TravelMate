using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Features.Queries.Commons.GetById;
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

namespace TravelMate.Application.Features.Queries.Settings.GetCountry.GetByCodeCountry
{
    public class GetByCodeCountryQueryHandler : IRequestHandler<GetByCodeCountryQuery, ResponseViewModelBase<CountryViewModel>>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public GetByCodeCountryQueryHandler(IMapper mapper, ICountryService countryService)
        {
            _countryService = countryService;
            _mapper= mapper;
        }
      
        public async Task<ResponseViewModelBase<CountryViewModel>> Handle(GetByCodeCountryQuery request, CancellationToken cancellationToken)
        {
            var countryEntity = await _countryService.GetFirstAsync(x=>x.Code==request.Code.ToUpper());
            var country = _mapper.Map<CountryViewModel>(countryEntity);
            return ResponseViewModelBase<CountryViewModel>.Success(country, ResultTypeEnum.Success);

        }
    }
}
