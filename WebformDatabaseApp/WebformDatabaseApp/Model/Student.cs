using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebformDatabaseApp.Model
{
    public class Student
    {


        public int studentId { get; set; }
        public string Name { get; set; }
        public String Email{get;set;}
        public string Phone { get; set; }
        public string RegNo { get; set; }
      

        public  Student(string name, string email, string phone, string regNo) 
    {

            Name = name;
            Email = email;
            Phone = phone;
            RegNo=regNo;
        
        
        
        }
        public Student() { 
        
        }
    
    
    
    }

}