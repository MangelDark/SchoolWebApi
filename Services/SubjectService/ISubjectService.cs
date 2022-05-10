using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.SubjectService
{
    public interface ISubjectService
    {
        IEnumerable<Subject> GetAllSubject();
        Subject GetSubject(int id);
        void InsertSubject(Subject subject);
        void UpdateSubject(Subject subject);
        void DeleteSubject(int id);
    }
}
