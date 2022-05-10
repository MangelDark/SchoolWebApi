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
    public class QualificationMapper : IEntityTypeConfiguration<Qualification>

    {
       public void Configure(EntityTypeBuilder<Qualification> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_qualificationid");
            builder.Property( x => x.Id).HasColumnType("int").ValueGeneratedOnAdd().HasColumnName("Id");
            builder.Property(x => x.FirstPractice).HasColumnName("firstpratice").HasColumnType("float");
            builder.Property(x => x.SecondPractice).HasColumnName("secondpratice").HasColumnType("float");
            builder.Property(x => x.FirstPartExam).HasColumnName("firstexamn").HasColumnType("float");
            builder.Property(x => x.SecondPartExam).HasColumnName("secondpartExam").HasColumnType("float");
            builder.Property(x => x.Final).HasColumnName("final").HasColumnType("int");
            builder.Property(x => x.CreatedDate).HasColumnName("created_date").HasColumnType("datetime");
            builder.Property(x => x.UpdatedDate).HasColumnName("updated_date").HasColumnType("datetime");
            builder.Property(x => x.IsActive).HasColumnType("bit").HasColumnName("isactive");

        }

    }
}
