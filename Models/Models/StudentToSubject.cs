using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class StudentToSubject
    {
        public int IdStudent { get; set; }
        public Student Student { get; set; }
        public int  IdSubject { get; set; }
        public Subject  Subject { get; set; }

    }
}
