using Domain.Models;
using Repository.Repository_Patter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly IRepositoryPatters<Student> _repository;
        public StudentService(IRepositoryPatters<Student> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            var result = _repository.Get(id);
            _repository.Delete(result);
            _repository.SaveChanges();
        }

        public Student Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Student> GetAll()
        {
           return _repository.GetAll();
        }

        public void Insert(Student student)
        {
             _repository.Insert(student);
            
        }

        public void Update(Student student)
        {
           _repository.Update(student);
        }
    }
}
