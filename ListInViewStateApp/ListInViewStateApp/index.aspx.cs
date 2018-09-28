using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListInViewStateApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (ViewState["StudentsName"] == null)
            {
                List<string> nameList = new List<string>();
                nameList.Add(nameTextBox.Text);
                ViewState["StudentsName"] = nameList;
            }
            else {
                List<String> nameList = (List<string>)ViewState["StudentsName"];

                nameList.Add(nameTextBox.Text);
            }
                
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
        
            List<string> nameList=(List<string>)ViewState["studentsName"];
            studentTextBox.Text = nameList.Count.ToString();
            foreach (string name in nameList) {

                studentListBox.Items.Add(name);
            
            }

        }
    }
}