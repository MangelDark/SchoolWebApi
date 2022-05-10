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
    public class StudentMapper : IEntityTypeConfiguration<Student>
    {
        public void Configure( EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_studentid");
            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasColumnType("INT");

            builder.Property(x => x.Name).HasColumnName("name")
                .HasColumnType("NVARCHAR(200)").IsRequired();
            builder.Property(x => x.Lastname).HasColumnName("lastname")
                .HasColumnType("NVARCHAR(500)").IsRequired();
            builder.Property(x => x.Yeard).HasColumnName("yeard")
                .HasColumnType("INT");
            builder.Property(x => x.Births).HasColumnName("birthday")
                .HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Email).HasColumnName("email")
                .HasColumnType("NVARCHAR(200)");
            builder.Property(x => x.CreatedDate).HasColumnName("created_date")
                .HasColumnType("datetime");
            builder.Property(x => x.UpdatedDate).HasColumnName("udated_date")
                .HasColumnType("datetime");
            builder.Property(x => x.IsActive).HasColumnName("isactive")
                .HasColumnType("bit");
            

        }



    }
}
