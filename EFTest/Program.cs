using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamContext context = new ExamContext();
            context.Database.EnsureCreated();
            context.Students.Add(new Student()
            {
                Name="Василий Петров"
            });
            context.SaveChanges();
            IQueryable<Student> students = from st in context.Students
                                           where st.Course == 2
                                           select st;
            //IQueryable<Student> students = context.Students.FromSqlRaw("SELECT * from Students where Course = 2");
            //IQueryable<Student> students = context.Students.Where(st => st.Course == 2);



            IQueryable <Teacher> teachers = from t in context.Teachers
                                           join exam in context.Exams on t equals exam.Teacher
                                           where exam.Students.Any(st => st.Course == 2)
                                           select t;


            List <Student> list = students.ToList();
            foreach (Student student in students)
                Console.WriteLine($"{student.Name} - {student.Course} - Курс");
            context.Dispose();
        }
    }
}
