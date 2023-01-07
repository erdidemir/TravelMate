using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Models.Settings
{
    public class CountryViewModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        public int CountryEnumId { get; set; }
    }
}
