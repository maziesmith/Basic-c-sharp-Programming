using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ItemPrizeAPp
{
    public partial class total_prize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            int item = Convert.ToInt32(numberTextBox.Text);
            int unit = Convert.ToInt16(unitTextBox.Text);
            double result = item * unit;
            ViewState["clicks"] = result.ToString();
            
        }

        protected void showPrize_Click(object sender, EventArgs e)
        {
            Label3.Text ="total prize:"+ (ViewState["clicks"]).ToString();
        }
    }
}