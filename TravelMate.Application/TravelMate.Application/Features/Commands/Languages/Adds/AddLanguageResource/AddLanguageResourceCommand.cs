using TravelMate.Application.Models.Commons;
using MediatR;

namespace TravelMate.Application.Features.Commands.Languages.Adds.AddLanguageResource
{
    public class AddLanguageResourceCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public string LanguageCode { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
