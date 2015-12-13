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
            foreach (Student student in studentRepo.GetStudents())
            {
                Console.WriteLine("Student Id:{0}, Student Name: {1}",student.Id, student.Name);
            }
        }
    }
}
