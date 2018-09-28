using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebformDatabaseApp.Model;

namespace WebformDatabaseApp.DAL
{
    public class StudentGateway
    {

        public int SaveStudent(Student student) {


            string connectionstring = @"server =DESKTOP-41DK70G; Database= StudentDb;integrated security=true";

            SqlConnection connection = new SqlConnection(connectionstring);
            string Query = "insert into Student values ( '" + student.Name + "','" + student.Email + "','" + student.Phone + "' ,'" + student.RegNo + "')";
            SqlCommand cmd = new SqlCommand(Query, connection);

            connection.Open();
            int a = cmd.ExecuteNonQuery();


            connection.Close();


            return a;
        }


    }
}