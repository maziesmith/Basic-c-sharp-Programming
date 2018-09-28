using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssociationApp
{
    public class Department
    {
        public string  Code { get; set; }
        public string Name { get; set; }

        public List<Student> students { get;set; }

        public Department(string code, string name)
        {

            code = Code;
            name = Name;
        }

        public Department()
        {
            students=new List<Student>();
        }

        public void AddStudent(Student aStudent)
        {
            
            students.Add(aStudent);
        }
    
    }

}