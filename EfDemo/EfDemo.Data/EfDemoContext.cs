using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfDemo.Entity;

namespace EfDemo.Data
{
    public class EfDemoContext:DbContext
    {
        public EfDemoContext():base("name=EfDemoConnection")
        {
            
        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; } 
        
    }
}
