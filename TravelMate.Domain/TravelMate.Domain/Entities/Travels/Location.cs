using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Entities.Commons;
using TravelMate.Domain.Entities.Settings;

namespace TravelMate.Domain.Entities.Travels
{
    public class Location : EntityBase
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public bool IsIn { get; set; }

        public User User { get; set; }
        public Country Country { get; set; }
        public ICollection<Travel> DepartTravels { get; set; }
        public ICollection<Travel> ArriveTravels { get; set; }

    }
}
