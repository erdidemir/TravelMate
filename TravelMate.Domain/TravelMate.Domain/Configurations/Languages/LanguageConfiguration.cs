using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Configurations.Commons;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Domain.Configurations.Languages
{
    public class LanguageConfiguration : EntityTypeConfigurationBase<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> entity)
        {

            entity.HasKey(p => p.Code);
            entity.Property(p => p.LanguageEnumId).IsRequired();
            entity.Property(p => p.Name).IsRequired();


            #region ForeingKey

            #endregion

            #region Index
            entity.HasIndex(e => new { e.LanguageEnumId }, "UIX_LanguageEnumId").IsUnique();
            entity.HasIndex(e => e.Name, "UIX_LanguageName").IsUnique();
            #endregion
        }
    }
}
