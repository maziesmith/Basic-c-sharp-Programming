using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicleApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            Vehicle avehicle = new Vehicle();
            avehicle.name = nameTextBox.Text;
            avehicle.regNo = Convert.ToInt16(regNoTextBox.Text);
            ViewState["Vehicle"] = avehicle;
           //avehicle.speedList = new List<double>();

        }

        protected void enterButton_Click(object sender, EventArgs e)
        {
            Vehicle avehicle = (Vehicle)ViewState["Vehicle"];
            double speed = Convert.ToDouble(speedTextBox.Text);

            avehicle.speedList.Add(speed);



        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Vehicle avehicle = (Vehicle)ViewState["Vehicle"];


            maxSpeedTextBox.Text = avehicle.GetMaxSpeed().ToString();
            minSpeedTextBox.Text = avehicle.GetMinSpeed().ToString();
            averageSpeedTextBox.Text = avehicle.GetAvgSpeed().ToString();


        }
    }
}