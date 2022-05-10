using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CourseService
{
    public interface ICourseService
    {

        IEnumerable<Course> GetAll();
        Course Get(int id);
        void Insert(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}
