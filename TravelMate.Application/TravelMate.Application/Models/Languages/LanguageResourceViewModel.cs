using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Models.Languages
{
    public class LanguageResourceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}
