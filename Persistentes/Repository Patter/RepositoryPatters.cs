using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository_Patter
{
    public class RepositoryPatters<T> : IRepositoryPatters<T> where T : BaseEntity
    {

        private readonly ApplicationDbContextSchool _applicationDbContextSchool;
        private DbSet<T> entities;
        public RepositoryPatters(ApplicationDbContextSchool applicationDbContextSchool)
        {
            _applicationDbContextSchool = applicationDbContextSchool;
            entities = _applicationDbContextSchool.Set<T>();
        }

        public void Delete(T entity)
        {
           if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _applicationDbContextSchool.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _applicationDbContextSchool.SaveChanges();
        }

        public void Remove(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _applicationDbContextSchool.SaveChanges();
        }

        public void Update(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _applicationDbContextSchool.SaveChanges();
        }
    }
}
