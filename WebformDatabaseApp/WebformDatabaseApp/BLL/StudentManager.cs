using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebformDatabaseApp.DAL;
using WebformDatabaseApp.Model;

namespace WebformDatabaseApp.BLL
{
    public class StudentManager
    {
      StudentGateway studentGateway=new StudentGateway();
        public string SaveStudent(Student student)
        { 
        
        int a=studentGateway.SaveStudent(student);
            
        
        if (a > 0)
        {
            return "saved sucesfully";


        }

        else
            return ("insert correctly");

        }

        
        }
        
        
        
        }


