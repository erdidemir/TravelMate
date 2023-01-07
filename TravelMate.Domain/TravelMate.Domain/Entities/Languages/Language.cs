using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Entities.Commons;

namespace TravelMate.Domain.Entities.Languages
{
    public class Language : EntityBase
    {
        public string Name { get; set; }
        public int LanguageEnumId { get; set; }
        public string Code { get; set; }
        public ICollection<LanguageResource> LanguageResources { get; set; }

    }
}
