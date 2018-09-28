using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssociationApp
{
    public partial class StudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        { 
           string name = nameTextBox.Text;
            string regNo = regTextBox.Text;
            string email = emailTextBox.Text;

            Student studentone=new Student(name,regNo,email);


        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Student studentone=new Student();
            Department department = (Department) Session["Department"];
       var a=department.AddStudent(studentone);
            messageLabe.Text = "" + department.Code + "" + department.Name;
           
        }
    }
}