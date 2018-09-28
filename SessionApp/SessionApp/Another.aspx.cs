using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionApp
{
    public partial class Another : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void anotherButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Person person = (Person) Session["object"];
            messageLabel.Text = "  " + person.Name + "" + person.Email + "" + person.Phone;
        }
    }
}