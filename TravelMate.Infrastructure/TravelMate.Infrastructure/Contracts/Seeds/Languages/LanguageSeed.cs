using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Infrastructure.Contracts.Seeds.Languages
{
    public static class LanguageSeed
    {
        public static List<Language> LanguageList()
        {
            return new List<Language>()
            {
                new  Language {LanguageEnumId=1,Name="English",Code="en-US"},
                new  Language {LanguageEnumId=2,Name="Turkish", Code="tr-TR"},
                new  Language {LanguageEnumId=3,Name="Français",Code="fr-FR"},
                new  Language {LanguageEnumId=4,Name="Deutsch", Code="de-DE"},
                new  Language {LanguageEnumId=5,Name="Русский",Code="ru-RU"},
                new  Language {LanguageEnumId=6,Name="עִברִית",Code="he-IL"},
                new  Language {LanguageEnumId=7,Name="عربي",Code="ar-AE"},
            };
        }

    }
}
