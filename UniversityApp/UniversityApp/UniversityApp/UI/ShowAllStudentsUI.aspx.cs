using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityApp.BLL;
using UniversityApp.Model;

namespace UniversityApp.UI
{
    public partial class ShowAllStudentsUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentManager studentManager = new StudentManager();

            studentsGridView.DataSource = studentManager.GetAllStudents();
            studentsGridView.DataBind();
        }
    }
}