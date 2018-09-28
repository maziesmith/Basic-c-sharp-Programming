using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssociationApp

{
    public class Student
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }

        public Student(string name, string regNo, string email)
        {
            name = Name;
            regNo = RegNo;
            email = Email;

        }

        public Student()
        {


        }
    }
}