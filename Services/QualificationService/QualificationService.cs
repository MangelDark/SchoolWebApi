using Domain.Models;
using Repository.Repository_Patter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.QualificationService
{
    public class QualificationService : IQualificationService
    {
        private readonly IRepositoryPatters<Qualification> _repository;
        public QualificationService(IRepositoryPatters<Qualification> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            var result = _repository.Get(id);
            _repository.Delete(result);
            _repository.SaveChanges();  
        }

        public Qualification Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Qualification> GetAll()
        {
            return _repository.GetAll();
        }

        public void Insert(Qualification qualification)
        {
            _repository.Insert(qualification);
        }

        public void Update(Qualification qualification)
        {
           _repository.Update(qualification);
        }
    }
}
