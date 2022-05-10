using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.QualificationService
{
    public interface IQualificationService
    {
        IEnumerable<Qualification> GetAll();
        Qualification Get(int id);
        void Insert(Qualification qualification);
        void Update(Qualification qualification);
        void Delete(int id);

    }
}
