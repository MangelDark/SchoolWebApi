using Domain.Models;
using Repository.Repository_Patter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.SubjectService
{
    public class SubjectService : ISubjectService
    {
        private readonly IRepositoryPatters<Subject> _repository;

        public SubjectService(IRepositoryPatters<Subject> repository)
        {
            _repository = repository;
        }
        public void DeleteSubject(int id)
        {
            var result = _repository.Get(id);
            _repository.Delete(result);
            _repository.SaveChanges();
        }

        public Subject GetSubject(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Subject> GetAllSubject()
        {
            return _repository.GetAll();
        }

        public void InsertSubject(Subject subject)
        {
             _repository.Insert(subject);
        }

        public void UpdateSubject(Subject subject)
        {
            _repository.Update(subject);
        }
    }
}
