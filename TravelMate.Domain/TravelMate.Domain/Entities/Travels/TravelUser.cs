using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Entities.Commons;

namespace TravelMate.Domain.Entities.Travels
{
    public class TravelUser : EntityBase
    {
        public int TravelId { get; set; }

        public int UserId { get; set; }

        public Travel Travel { get; set; }
        public User User { get; set; }
    }
}
