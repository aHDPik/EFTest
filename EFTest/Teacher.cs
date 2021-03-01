using System;
using System.Collections.Generic;
using System.Text;

namespace EFTest
{
    public enum Position
    {
        Teacher,
        Docent,
        Professor
    }

    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public Position Position { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
