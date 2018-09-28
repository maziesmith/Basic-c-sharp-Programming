using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformDatabaseApp
{
    public partial class StudentWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Save_Click(object sender, EventArgs e)
        {



            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string phone = PhoneTextBox.Text;
            Student student = new Student(name, email, phone);





            string ConnectionString = @"server =DESKTOP-41DK70G; Database= StudentDb;integrated security=true";

            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "insert into Student values ( '" + student.Name + "','" + student.Email + "','" + student.Phone + "',     )";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int r = command.ExecuteNonQuery();
            connection.Close();

        }
    }
}