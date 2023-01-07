using TravelMate.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Languages.Updates.UpdateLanguageResource
{
    public class UpdateLanguageResourceCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public int Id { get; set; }
        public string LanguageCode { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
