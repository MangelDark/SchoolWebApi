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
    public class StudentToSubjectMapper : IEntityTypeConfiguration<StudentToSubject>
    {
        public void Configure (EntityTypeBuilder<StudentToSubject> builder)
        {
            builder.HasKey(sc => new { sc.IdStudent, sc.IdSubject });

            builder.HasOne(x=>x.Student).WithMany(x=>x.Subjects).HasForeignKey(x=>x.IdStudent);
            builder.HasOne(x=>x.Subject).WithMany(x=>x.Students).HasForeignKey(x=>x.IdSubject);
        }
    }
}
