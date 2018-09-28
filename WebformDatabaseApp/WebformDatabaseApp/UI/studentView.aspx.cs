using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;
using WebformDatabaseApp.Model;

namespace WebformDatabaseApp.UI
{
    public partial class StudentView : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionstring =@"Server=DESKTOP-41DK70G;database=StudentDb;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select *from Student";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            while (reader.Read()) {
                Student student = new Student();
                student.studentId = (int)reader["studentId"];
                student.Name = reader["name"].ToString();
                student.Email = reader["Email"].ToString();
                student.Phone = reader["Phone"].ToString();
                student.RegNo = reader["RegNo"].ToString();

                students.Add(student);
            
            }

            reader.Close();
            connection.Close();
          



        }
    }
}