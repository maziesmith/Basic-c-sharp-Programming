using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contour;
using UniversityWebbAPP.BLL;
using UniversityWebbAPP.Model;

namespace UniversityWebbAPP.Ui
{
    public partial class StudentDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentShow.aspx");
        }

       

        protected void DeleteButton_Click(object sender, EventArgs e)
        {StudentManager studentManager=new StudentManager();
            Student student =new Student();
            student.RegNo = regTextBox.Text;
            messageLabel.Text = studentManager.DeleteRegNo(student);
        }
    }
}