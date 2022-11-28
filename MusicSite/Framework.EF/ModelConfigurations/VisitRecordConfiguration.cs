using Framework.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.EF.ModelConfigurations
{
    internal class VisitRecordConfiguration : IEntityTypeConfiguration<VisitRecord>
    {
        public void Configure(EntityTypeBuilder<VisitRecord> entity)
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY"); 
            entity.ToTable("VisitRecord"); 
        }
    } 
}
