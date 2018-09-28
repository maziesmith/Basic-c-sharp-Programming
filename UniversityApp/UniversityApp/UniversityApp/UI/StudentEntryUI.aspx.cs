using System;
using System.Data.SqlClient;
using UniversityApp.BLL;
using UniversityApp.Model;

namespace UniversityApp.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            StudentManager studentManager = new StudentManager();
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string regNo = regNoTextBox.Text;
            Student student = new Student(name, email, phone, regNo);
            messageLabel.Text = studentManager.SaveStudent(student);
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowAllStudentsUI.aspx");
        }
    }
}