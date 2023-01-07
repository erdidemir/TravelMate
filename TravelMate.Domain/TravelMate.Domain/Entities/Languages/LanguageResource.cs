using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Entities.Commons;

namespace TravelMate.Domain.Entities.Languages
{
    public class LanguageResource : EntityBase
    {
        public string LanguageCode { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Language Language { get; set; }
    }
}
