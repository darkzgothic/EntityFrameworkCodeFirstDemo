using System;
using System.CodeDom;
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
        private readonly StudentContext _studentContext;
        public StudentRepo()
        {
            _studentContext=new StudentContext();
        }
        public List<Student> GetStudents()
        {
            return _studentContext.GetStudents();
        }

        public bool SaveStudent(Student student,out string error)
        {
            error = string.Empty;
            if (student.Name == String.Empty)
            {
                error = "Student Name Empty";
                return false;
            }

            try
            {
                //update existing student
                if (student.Id > 0)
                {
                    if (!_studentContext.UpdateStudent(student, out error))
                    {
                        return false;
                    }
                }
                //create new student
                else
                {
                    if (!_studentContext.CreateStudent(student, out error))
                    {
                        return false;
                    }
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
            return true;
        }
    }
}
