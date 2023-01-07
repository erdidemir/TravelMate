using TravelMate.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Settings.Adds.AddCountry
{
    public class AddCountryCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public string Name { get; set; }
        public int CountryEnumId { get; set; }

    }
}
