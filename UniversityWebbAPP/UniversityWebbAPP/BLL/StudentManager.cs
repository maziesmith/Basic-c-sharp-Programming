using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using UniversityWebbAPP.DAL;
using UniversityWebbAPP.Model;

namespace UniversityWebbAPP.BLL
{
    public class StudentManager
    {
        private StudentGateWay studentGate = new StudentGateWay();

        public string SaveStudent(Student student)
        {
        int r=    studentGate.SaveStudent(student);
            if(r>0)
            {
                return "saved successfully";

            }
            else
            {
                return "not succesfully";

            }
        }

        public List<Student> ShowStudent()
        {


        return studentGate.ShowStudent();

        }

        public string UpdateStudent(Student student)
        {
            Student aStudent = studentGate.Isexist(student);
            if (aStudent == null)
            {
                return "registration number is not exist";


            }

            else
            {
                if (studentGate.UpdateStudent(student))
                {
                    return "sucesfull";


                }

                else
                {
                    return "unsucessfull";
                }
                
            }
       }


        public string DeleteRegNo(Student student)
        {
            
            Student aStudent=new Student();
            aStudent = studentGate.Isexist(student);
            if (aStudent == null)
            {
                return "registration number is not exist";


            }
            else
            {
                if (studentGate.DeleteRegNo(student))
                    return "resgistration number of" + student.RegNo + "has been deleted";

                else
                {
                    return "unsucessfull";
                }
            }
       
            
        }

        public string SearchStudent(Student student)
        {
            Student aStudent = studentGate.Isexist(student);
            if (aStudent == null)
            {
                return "registration number is not exist";


            }

            else
            {
                if (studentGate.SearchStudent(student))
                {
                    return "sucesfull";


                }

                else
                {
                    return "unsucessfull";
                }

            }
        }
    }


}
