using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberRangeApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox2.Text);
           //Response.Write("print All numbers from 1 to 100");
            for (int i = a; i < b; i++) {

                Response.Write(i+"</br");
            }
        }

        
    }
}