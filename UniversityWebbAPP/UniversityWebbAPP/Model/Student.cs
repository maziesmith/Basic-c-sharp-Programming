using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace UniversityWebbAPP.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        
        public string  Email { get; set; }
        public string Phone { get; set; }

        public string RegNo { get; set; }

        public int DepartmentId { get; set; }

        public Student(string name,string email,string phone,string regno, int departmentId)
        {
            Name = name;
            Email = email;
            Phone = phone;
            RegNo = regno;
            DepartmentId = departmentId;

        }


        public Student()
        {



        }

    }
}