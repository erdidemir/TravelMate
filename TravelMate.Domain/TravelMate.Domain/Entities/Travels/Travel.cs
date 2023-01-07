using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Entities.Commons;

namespace TravelMate.Domain.Entities.Travels
{
    public class Travel : EntityBase
    {
        public int UserId { get; set; }
        public int DepartLocationId { get; set; }
        public DateTime DepartTime { get; set; }

        public int ArriveLocationId { get; set; }
        public string Description { get; set; }

        public int SeatingCapacity { get; set; }

        public User User { get; set; }
        public Location DepartLocation { get; set; }
        public Location ArriveLocation { get; set; }

        public ICollection<TravelUser> TravelUsers { get; set; }

    }
}
