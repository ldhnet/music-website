using Framework.Models.Entities;
using Framework.Utility.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Framework.EF.ModelConfigurations
{
    internal class Biz_SongListConfiguration : IEntityTypeConfiguration<Biz_Song_List>
    {
        public void Configure(EntityTypeBuilder<Biz_Song_List> entity)
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable("Biz_Song_List"); 
        }
    } 
}
