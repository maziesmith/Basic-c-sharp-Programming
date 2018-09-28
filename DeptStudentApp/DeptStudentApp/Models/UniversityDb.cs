using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeptStudentApp.Models
{
    public class UniversityDb:DbContext
    {
        public UniversityDb()
            : base("projectdb")
        {
            


        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}