using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.StudentService
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        void Insert(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
