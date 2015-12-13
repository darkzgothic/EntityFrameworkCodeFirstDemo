using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfDemo.Data;
using EfDemo.Entity;

namespace EfDemo.Repo
{
    public class StudentRepo
    {
        public List<Student> GetStudents()
        {
            using (var dbcontext = new EfDemoContext())
            {
                return dbcontext.Students.ToList();
            }
        }
    }
}
