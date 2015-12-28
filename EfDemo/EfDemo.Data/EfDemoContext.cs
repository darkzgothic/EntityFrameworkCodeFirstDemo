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
        private static System.Data.Entity.SqlServer.SqlProviderServices _instance =
            System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        public EfDemoContext():base("name=EfDemoConnection")
        {
            
        }       
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; } 
        
    }
}
