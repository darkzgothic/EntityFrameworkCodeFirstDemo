using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfDemo.Entity;

namespace EfDemo.Data
{
    public class StudentContext
    {
        public List<Student> GetStudents()
        {
            using (var dbcontext = new EfDemoContext())
            {
                return dbcontext.Students.ToList();
            }
        }

        public bool CreateStudent(Student student,out string error)
        {
            error=string.Empty;            
            try
            {
                using (var dbcontext = new EfDemoContext())
                {
                    dbcontext.Students.Add(student);
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }

        public bool UpdateStudent(Student student, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new EfDemoContext())
                {
                    var studentToUpdate = dbcontext.Students.SingleOrDefault(s => s.Id == student.Id);

                    if (studentToUpdate == null)
                    {
                        error = "Invalid Student Found";
                        return false;
                    }
                    studentToUpdate.Name = student.Name;
                    studentToUpdate.DeptId = student.DeptId;
                    dbcontext.SaveChanges();

                    return true;
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }

        }
    }
}
