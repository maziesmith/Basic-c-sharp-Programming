using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityWebbAPP.BLL;
using UniversityWebbAPP.Model;

namespace UniversityWebbAPP.Ui
{
    public partial class StudentUpdare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {Student student=new Student();

            StudentManager studentManager =new StudentManager();

            student.RegNo = regTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Email = emailTextBox.Text;
            student.Phone = phoneTextBox.Text;
            
            messageLevel.Text = studentManager.UpdateStudent(student);
            

        }


        protected void ShowButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentShow.aspx");
        }
    }
}