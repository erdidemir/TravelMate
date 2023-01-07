using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Models.Commons;

namespace TravelMate.Application.Features.Commands.Travels.Adds
{
    public class AddTravelCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public int UserId { get; set; }

        #region DepartLocation
        public string DepartLocationName { get; set; }
        public string DepartLocationCityName { get; set; }
        public decimal? DepartLocationLongitude { get; set; }
        public decimal? DepartLocationLatitude { get; set; }

        #endregion

        #region ArriveLocation
        public string ArriveLocationName { get; set; }
        public string ArriveLocationCityName { get; set; }
        public decimal? ArriveLocationLongitude { get; set; }
        public decimal? ArriLocationveLatitude { get; set; }

        #endregion

        public DateTime DepartTime { get; set; }
        public string Description { get; set; }
        public int SeatingCapacity { get; set; }

    }
}
