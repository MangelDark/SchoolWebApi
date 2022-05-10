using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Subject : BaseEntity
    {
        public string Desctiption { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int IdCourse { get; set; }
        public Course Course { get; set; }
        public int IdQualification { get; set; }
        public Qualification Qualification { get; set; }
        public ICollection<StudentToSubject> Students { get; set; }

    }
}
