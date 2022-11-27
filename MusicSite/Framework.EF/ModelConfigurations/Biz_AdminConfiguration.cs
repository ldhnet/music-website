using Framework.Models.Entities;
using Framework.Utility.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Framework.EF.ModelConfigurations
{
    internal class Biz_AdminConfiguration : IEntityTypeConfiguration<Biz_Admin>
    {
        public void Configure(EntityTypeBuilder<Biz_Admin> entity)
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");
            entity.ToTable("Biz_Admin");

        }
    }
}
