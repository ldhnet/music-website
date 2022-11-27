using Framework.Models.Entities;
using Framework.Utility.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Framework.EF.ModelConfigurations
{
    internal class Biz_CollectConfiguration : IEntityTypeConfiguration<Biz_Collect>
    {
        public void Configure(EntityTypeBuilder<Biz_Collect> entity)
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable("Biz_Collect"); 
        }
    } 
}
