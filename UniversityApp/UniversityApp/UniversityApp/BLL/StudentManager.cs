using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityApp.DAL;
using UniversityApp.Model;

namespace UniversityApp.BLL
{
    public class StudentManager
    {
        StudentGateway studentGateway = new StudentGateway();
        public string SaveStudent(Student student)
        {
            if (student.RegNo.Length >= 7)
            {
                Student aStudent = studentGateway.IsExist(student);
                if (aStudent == null)
                {
                    int rowAffected = studentGateway.SaveStudent(student);
                    if (rowAffected > 0)
                    {
                        return "Saved successfully.";
                    }
                    else
                    {
                        return "Save failed.";
                    }
                }
                else
                {
                    return "Registration number must be unique.";
                }
            }
            else
            {
                return "Registration number must be atleast seven characters long.";
            }
        }

        public List<Student> GetAllStudents()
        {
            return studentGateway.GetAllStudents();
        }
    }
}