using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls.WebParts;
using UniversityWebbAPP.Model;

namespace UniversityWebbAPP.DAL
{
    public class DepartmetGateWay

    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["StudentDbConnectionString"]
            .ConnectionString;

        public List<Department> GetAllDepartment()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select *from   Department";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Department> departments = new List<Department>();

            while (reader.Read())
            {
                Department department = new Department();
                department.DepartmentId = (int) reader["DepartmentId"];
                department.Code = reader["Code"].ToString();
                department.Name = reader["Name"].ToString();


                departments.Add(department);
            }

            reader.Close();
            connection.Close();
            return departments;



        }




        public Department GetdepartmentById(int id)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select *from Department where DepartmentId=" + id;
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            Department department = null;
            while (reader.Read())
            {
                department=new Department();

                department. DepartmentId = (int) reader["DepartmentId"];
                department.Code = reader["Code"].ToString();
                department.Name = reader["Name"].ToString();




            }

            reader.Close();
            connection.Close();
            return department;


        }

    }
}
    
