using MediatR;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Travels;

namespace TravelMate.Application.Features.Queries.Travel.GetTravel
{
    public class GetTravelBySearchQuery : IRequest<ResponseViewModelBase<IReadOnlyList<TravelViewModel>>>
    {
        public string? DepartName { get; set; }
        public string? DepartCity{ get; set; }

        public string? ArriveName { get; set; }
        public string? ArriveCity { get; set; }


    }

}
