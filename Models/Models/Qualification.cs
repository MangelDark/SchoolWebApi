using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Qualification : BaseEntity
    {

        public float FirstPartExam { get; set; }
        public float SecondPartExam { get; set; }
        public float FirstPractice { get; set; }
        public float SecondPractice { get; set; }
        public int Final { get; set; }

        public ICollection<Subject> Subjects { get; set; }

    }
}
