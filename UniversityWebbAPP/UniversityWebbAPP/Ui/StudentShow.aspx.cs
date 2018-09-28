using System;
using UniversityWebbAPP.BLL;

namespace UniversityWebbAPP.Ui
{
    public partial class StudentShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentManager studentManager =new StudentManager();
          studentGridView.DataSource= studentManager.ShowStudent();
         studentGridView.DataBind();


        }

       

        
    }
}