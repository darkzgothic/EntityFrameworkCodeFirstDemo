using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfDemo.Entity;
using EfDemo.Repo;

namespace EfDemo.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentRepo = new StudentRepo();

            //Show existing students
            Console.WriteLine("***Existing Students***");
            foreach (Student student in studentRepo.GetStudents())
            {
                Console.WriteLine("Student Id:{0}, Student Name: {1}",student.Id, student.Name);
            }

            //insert new student
            Console.WriteLine("***Insert New Student***");
            string error;
            var newStudent = new Student()
            {
                Name = "New Student",
                DeptId = 1
            };

            if (studentRepo.SaveStudent(newStudent, out error))
            {
                Console.WriteLine("New Student inserted successfully");
            }
            else
            {
                Console.WriteLine("Error: {0}",error);
            }
            
            //display students after insertion
            Console.WriteLine("***Students after insertion***");
            foreach (Student student in studentRepo.GetStudents())
            {
                Console.WriteLine("Student Id:{0}, Student Name: {1}", student.Id, student.Name);
            }
        }
    }
}
