using Framework.Models.Entities;
using Framework.Utility.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Framework.EF.ModelConfigurations
{
    internal class Biz_SingerConfiguration : IEntityTypeConfiguration<Biz_Singer>
    {
        public void Configure(EntityTypeBuilder<Biz_Singer> entity)
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable("Biz_Singer"); 
        }
    } 
}
