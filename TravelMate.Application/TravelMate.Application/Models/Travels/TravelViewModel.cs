using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Models.Travels
{
    public class TravelViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        #region Depart
        public string DepartLocationName { get; set; }
        public string DepartLocationCityName { get; set; }
        public decimal? DepartLocationLongitude { get; set; }
        public decimal? DepartLocationLatitude { get; set; }

        #endregion

        #region Arrive
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
