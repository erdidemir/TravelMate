using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMate.Domain.Configurations.Commons;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Domain.Configurations.Languages
{
    public class LanguageResourceConfiguration : EntityTypeConfigurationBase<LanguageResource>
    {
        public override void Configure(EntityTypeBuilder<LanguageResource> entity)
        {
            base.Configure(entity);

            entity.Property(p => p.LanguageCode).IsRequired();
            entity.Property(p => p.Name).IsRequired();
            entity.Property(p => p.Value).IsRequired();


            #region ForeingKey
            entity.HasOne(x => x.Language).WithMany(x => x.LanguageResources).HasForeignKey(x => x.LanguageCode);
            #endregion

            #region Index


            entity.HasIndex(e => new { e.Name, e.LanguageCode }, "IX_LanguageResourceName_LanguageCode");
            #endregion
        }
    }
}
