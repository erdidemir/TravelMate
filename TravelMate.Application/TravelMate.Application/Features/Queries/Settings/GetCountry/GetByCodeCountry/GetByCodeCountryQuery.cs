using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Settings;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Settings.GetCountry.GetByCodeCountry
{
    public class GetByCodeCountryQuery: IRequest<ResponseViewModelBase<CountryViewModel>>
    {
        public string Code { get; set; }
    }
}
