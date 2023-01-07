using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Entities.Commons;
using TravelMate.Domain.Entities.Travels;

namespace TravelMate.Domain.Entities.Settings
{
    public class Country : EntityBase
    {
        public int CountryEnumId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}
