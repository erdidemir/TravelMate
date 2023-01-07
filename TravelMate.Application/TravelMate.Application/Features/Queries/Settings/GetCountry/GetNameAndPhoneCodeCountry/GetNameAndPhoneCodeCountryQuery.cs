using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Settings;
using MediatR;
using System.Collections.Generic;

namespace TravelMate.Application.Features.Queries.Settings.GetCountry.GetNameAndPhoneCodeCountry
{
    public class GetNameAndPhoneCodeCountryQuery : IRequest<ResponseViewModelBase<IReadOnlyList<CountryNameAndPhoneCodeViewModel>>>
    {
    }
}
