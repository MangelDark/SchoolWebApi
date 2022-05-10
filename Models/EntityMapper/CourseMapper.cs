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
    public class CourseMapper : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {

            builder.HasKey(x => x.Id).HasName("pk_courseid");
            builder.Property(x => x.Id).HasColumnType("INT").HasColumnName("Id").ValueGeneratedOnAdd();

            builder.Property(x => x.Ability).HasColumnName("ability").HasColumnType("int");
            builder.Property(x => x.ClassRoom).HasColumnName("classroom").HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.CreatedDate).HasColumnName("created_date").HasColumnType("datetime");
            builder.Property(x => x.UpdatedDate).HasColumnName("updated_date").HasColumnType("datetime");
            builder.Property(x => x.IsActive).HasColumnType("bit").HasColumnName("isactive");
        }
    }
}
