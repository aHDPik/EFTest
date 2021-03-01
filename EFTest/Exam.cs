using System;
using System.Collections.Generic;
using System.Text;

namespace EFTest
{
    public class Exam
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
