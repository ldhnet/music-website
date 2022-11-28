using Framework.Models.Entities;
using Framework.Utility.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Framework.EF.ModelConfigurations
{
    internal class Biz_BannerConfiguration : IEntityTypeConfiguration<Biz_Banner>
    {
        public void Configure(EntityTypeBuilder<Biz_Banner> entity)
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable("Biz_Banner"); 
        }
    } 
}
