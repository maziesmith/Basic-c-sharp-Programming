using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityWebbAPP.BLL;
using UniversityWebbAPP.Model;

namespace UniversityWebbAPP.Ui
{
    public partial class StudentSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void SearchButton_Click(object sender, EventArgs e)
        {
           Student student=new Student();
            student.RegNo = regTextBox.Text;
         string   connectionString=@"data source=DESKTOP-V3L4010;Database=StudentDb;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT *FROM STUDENT where RegNo='" + student.RegNo + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
          
            while (reader.Read())
            {
              
                if (reader.HasRows)
                {
                   nameLabel.Text= reader["Name"].ToString();
                    emailLabel.Text = reader["Email"].ToString();
              phoneLabel.Text = reader["Phone"].ToString();
                }
            }
            reader.Close();
            connection.Close();
             


        }
    }
}