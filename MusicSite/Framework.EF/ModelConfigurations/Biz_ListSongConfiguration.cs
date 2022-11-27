using Framework.Models.Entities;
using Framework.Utility.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Framework.EF.ModelConfigurations
{
    internal class Biz_ListSongConfiguration : IEntityTypeConfiguration<Biz_List_Song>
    {
        public void Configure(EntityTypeBuilder<Biz_List_Song> entity)
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable("Biz_List_Song"); 
        }
    } 
}
