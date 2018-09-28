using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Another.aspx");
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Person person=new Person();
            person.Name = nameTextBox.Text;
            person.Email = emailTextBox.Text;
            person.Phone = PhoneTextBox.Text;

            Session["object"] = person;
        }
    }
}