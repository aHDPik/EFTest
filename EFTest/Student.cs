using System;
using System.Collections.Generic;
using System.Text;

namespace EFTest
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
