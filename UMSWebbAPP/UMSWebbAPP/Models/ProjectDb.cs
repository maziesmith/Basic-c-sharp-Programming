using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UMSWebbAPP.Models
{
    public class ProjectDb:DbContext
    {
        public ProjectDb() : base("StudentDb")
        {
            

        }

       public DbSet<Student>Students { get; set; }
       public DbSet<Department> Departments { get; set; }


    }
}