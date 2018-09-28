using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityWebbAPP.Model;
 using UniversityWebbAPP.Ui;

namespace UniversityWebbAPP.DAL
{
    public class StudentGateWay
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["StudentDbConnectionString"].ConnectionString;

        public int SaveStudent(Student student)
        {

            SqlConnection connection =new SqlConnection(connectionString);

            string query = "insert into Student (Name,Email,Phone,RegNo,DepartmentId) values('" + student.Name + "','" + student.Email + "','" + student.Phone + "','" + student.RegNo + "',"+student.DepartmentId+")";


            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            int r = command.ExecuteNonQuery();
            connection.Close();

            return r;
        }

        public List<Student> ShowStudent()
        {
SqlConnection connection =new SqlConnection(connectionString);

string query = "select *from Student";

            SqlCommand command =new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students =new List<Student>();
            while (reader.Read())
            {
            Student student =new Student();
                student.StudentId = (int) reader["StudentId"];
                student.Name = reader["Name"].ToString();
                student.Email =  reader["Email"].ToString();
                student.Phone = reader["Phone"].ToString();
                student.RegNo = reader["RegNo"].ToString();

                students.Add(student);

            }


            reader.Close();
            connection.Close();
            return students;

        }

        public Student Isexist(Student student)
        {
SqlConnection connection= new SqlConnection(connectionString);

            string query = "SELECT *FROM STUDENT WHERE  RegNo= '"+student.RegNo+"' ";

            SqlCommand command =new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Student aStudent = null;

            if (reader.HasRows)
            {
                reader.Read();

                aStudent=new Student();
                aStudent.StudentId =(int) reader["StudentId"];
                aStudent.Name = reader["Name"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Phone = reader["Phone"].ToString();
                aStudent.RegNo = reader["RegNo"].ToString();


            }
            reader.Close();
            connection.Close();
            return aStudent;

        }




        public bool UpdateStudent(Student student) {

            SqlConnection connection = new SqlConnection(connectionString);
            string query ="Update Student set Name= '"+student.Name+"',Email= '"+student.Email+"',Phone='"+student.Phone+"' where  RegNo='"+student.RegNo+"'";


            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
          int r=  command.ExecuteNonQuery();

          connection.Close();

          if (r > 0)
              return true;
          else
              return false;



        }


        public bool DeleteRegNo(Student student)
        {
            SqlConnection connection =new SqlConnection(connectionString);
            string query = "DELETE FROM STUDENT where RegNo='" + student.RegNo + "'";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            int r = command.ExecuteNonQuery();
            connection.Close();
            if(r>0)
            return true;
            else
            {
                return false;
            }
            


        }

        public bool SearchStudent(Student student)
        {


            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT *FROM STUDENT where RegNo='" + student.RegNo + "'";
            SqlCommand command =new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Student aStudent = null;
            while (reader.Read())
            {
                aStudent = new Student();
                if (reader.HasRows)
                {
                    aStudent.Name = reader["Name"].ToString();
                    aStudent.Email = reader["Email"].ToString();
                    aStudent.Phone = reader["Phone"].ToString();
                }
            }
            reader.Close();
                connection.Close();
             
            
            return false;



      }
    }
}