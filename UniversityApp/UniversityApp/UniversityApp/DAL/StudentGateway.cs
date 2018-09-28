using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Configuration;
using UniversityApp.Model;

namespace UniversityApp.DAL
{
    public class StudentGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;
        public int SaveStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Student1 VALUES ('" + student.Name + "', '" + student.Email + "', '" + student.Phone + "', '" + student.RegNo + "')";

            SqlCommand command = new SqlCommand(query, connection);
            //command.CommandText = query;
            //command.Connection = connection;

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }

        public List<Student> GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Student1";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student();
                student.StudentID = (int)reader["StudentID"];
                student.Name = reader["Name"].ToString();
                student.Email = reader["Email"].ToString();
                student.Phone = reader["Phone"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                //Student student = new Student(name, email, phone, regNo);
                //student.StudentID = studentId;
                students.Add(student);
            }
            reader.Close();
            connection.Close();

            return students;
        }

        public Student IsExist(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Student1 WHERE RegNo='" + student.RegNo + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Student aStudent = null;
            if (reader.HasRows)
            {
                reader.Read();
                aStudent = new Student();
                aStudent.StudentID = (int)reader["StudentID"];
                aStudent.Name = reader["Name"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Phone = reader["Phone"].ToString();
                aStudent.RegNo = reader["RegNo"].ToString();
            }
            reader.Close();
            connection.Close();

            return aStudent;
        }
    }
}