using Framework.Models.Entities;
using Framework.Utility.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Framework.EF.ModelConfigurations
{
    internal class Biz_CommentConfiguration : IEntityTypeConfiguration<Biz_Comment>
    {
        public void Configure(EntityTypeBuilder<Biz_Comment> entity)
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable("Biz_Comment"); 
        }
    } 
}
