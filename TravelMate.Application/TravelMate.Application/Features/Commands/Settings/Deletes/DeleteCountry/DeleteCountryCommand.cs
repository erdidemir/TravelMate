using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Settings;
using MediatR;

namespace TravelMate.Application.Features.Commands.Settings.Deletes.DeleteCountry
{
    public class DeleteCountryCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public string Code { get; set; }
   
    }
}
