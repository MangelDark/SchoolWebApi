using Domain.EntityMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ApplicationDbContextSchool : DbContext
    {
        public ApplicationDbContextSchool(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new StudentMapper());
            model.ApplyConfiguration(new SubjectMapper());
            model.ApplyConfiguration(new CourseMapper());
            model.ApplyConfiguration(new QualificationMapper());
            model.ApplyConfiguration(new StudentToSubjectMapper());
            base.OnModelCreating(model);
        }
    }
}
