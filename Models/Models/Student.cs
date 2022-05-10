using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class Student : BaseEntity
    {
        public string Name  { get; set; }
        public string Lastname { get; set; }
        public string  Email { get; set; }
        public string Phone { get; set; }
        public DateTime Births { get; set; }
        public int Yeard { get; set; }   
  
        public ICollection<StudentToSubject> Subjects { get; set; }
    }
}
