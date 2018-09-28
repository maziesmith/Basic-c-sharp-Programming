using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MethodInWebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Salary asalary=new Salary();
            asalary.basicAmount=Convert.ToDouble(basicAmountTextBox.Text);
            asalary.houseRentPercentage=Convert.ToDouble(houserentPercentageTextBox.Text);
            asalary.medicalAllowancePercentage=Convert.ToDouble(medicalAllowanceTextBox.Text);

            ViewState["Salary"]=asalary;
        }

        protected void showButtonTextBox_Click(object sender, EventArgs e)
        {
            Salary asalary = (Salary)ViewState["Salary"];
            totalAmountlevel.Text = asalary.CalculateSalary().ToString();

             
        }
    }
}