using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntityMapper
{
    public class SubjectMapper : IEntityTypeConfiguration<Subject>
    {

        public void Configure(EntityTypeBuilder<Subject> builder)
        {

            builder.HasKey(x => x.Id).HasName("pk_sujectid");
            builder.Property(x=>x.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();

            builder.Property(x=>x.Name).HasColumnName("name").HasColumnType("NVARCHAR(200)").IsRequired();
            builder.Property(x => x.Desctiption).HasColumnName("description").HasColumnType("NVARCHAR(500)").IsRequired();
            builder.Property(x => x.Credits).HasColumnName("credits").HasColumnType("int");
            builder.Property(x => x.CreatedDate).HasColumnName("created_date").HasColumnType("datetime");
            builder.Property(x => x.UpdatedDate).HasColumnName("updated_date").HasColumnType("datetime");
            builder.Property(x => x.IsActive).HasColumnName("isactive").HasColumnType("bit");
            //Relation one to many
            builder.HasOne(x=>x.Course).WithMany(c => c.Subjects).HasForeignKey(x => x.IdCourse);
            builder.HasOne(x => x.Qualification).WithMany(c => c.Subjects).HasForeignKey(x => x.IdQualification);
        }
    }
}
