using Framework.Models.Entities;
using Framework.Utility.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Framework.EF.ModelConfigurations
{
    internal class Biz_ConsumerConfiguration : IEntityTypeConfiguration<Biz_Consumer>
    {
        public void Configure(EntityTypeBuilder<Biz_Consumer> entity)
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable("Biz_Consumer"); 
        }
    } 
}
