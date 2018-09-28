using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Student
    {


        public int studentId { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }
        public string Phone { get; set; }


        public Student(string name, string email, string phone)
        {

            Name = name;
            Email = email;
            Phone = phone;



        }
    


    }
}