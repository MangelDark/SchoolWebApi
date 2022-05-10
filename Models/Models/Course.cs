using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Course : BaseEntity
    {
        public string ClassRoom { get; set; }
        public int Ability { get; set; }
        public string Location { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
