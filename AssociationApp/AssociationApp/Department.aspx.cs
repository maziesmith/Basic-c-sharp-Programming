using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssociationApp
{
    public partial class Department1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveDepartmentButton_Click(object sender, EventArgs e)
        {
            Department department =new Department();
            department.Code = codeTextBox.Text;
            department.Name = nameTextBox.Text;
            Session["Department"] = department;

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentUI.aspx");
        }
    }
}