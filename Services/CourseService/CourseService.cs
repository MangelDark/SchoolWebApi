using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Repository_Patter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CourseService
{
    public class CourseService : ICourseService
    {
        private readonly IRepositoryPatters<Course> _repository;
     
        public CourseService(IRepositoryPatters<Course> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
           var result = _repository.Get(id);
            _repository.Delete(result);
            _repository.SaveChanges();

        }

        public Course Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return _repository.GetAll();
        }

        public void Insert(Course course)
        {
            _repository.Insert(course);
        }

        public void Update(Course course)
        {
            _repository.Update(course);
        }
    }
}
