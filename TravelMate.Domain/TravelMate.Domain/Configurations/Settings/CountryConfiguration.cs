using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMate.Domain.Configurations.Commons;
using TravelMate.Domain.Entities.Settings;

namespace TravelMate.Domain.Configurations.Settings
{
    public class CountryConfiguration : EntityTypeConfigurationBase<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> entity)
        {

            entity.HasKey(k => new { k.Code });
            entity.Property(p => p.CountryEnumId).IsRequired();
            entity.Property(p => p.Name).IsRequired();
            entity.Property(p => p.Code).IsRequired();
            entity.Property(p => p.PhoneCode).IsRequired();
            entity.Property(e => e.CreatedDate).IsRequired();
            entity.Property(e => e.IsActive).IsRequired();
            entity.Property(e => e.DisplayOrder).IsRequired();

            #region ForeingKey

            #endregion

            #region Index
            entity.HasIndex(e => new { e.CountryEnumId }, "UIX_CountryEnumId").IsUnique();
            entity.HasIndex(e => e.Name, "UIX_CountryName").IsUnique();


            #endregion
        }
    }
}
