using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebformDatabaseApp.BLL;
using WebformDatabaseApp.Model;



namespace WebformDatabaseApp.UI
{
    public partial class StudentWebForm : System.Web.UI.Page
    {
      
      

        protected void Save_Click(object sender, EventArgs e)
        {
            StudentManager studentmanager = new StudentManager();


            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string phone = PhoneTextBox.Text;
            string regNo = RegNoTextBox.Text;

            Student student = new Student(name, email, phone, regNo);


           

        }
      

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentView.aspx");


        }

        
    }
}