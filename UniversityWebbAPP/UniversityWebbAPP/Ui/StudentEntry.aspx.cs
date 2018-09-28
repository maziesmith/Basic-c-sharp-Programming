using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityWebbAPP.BLL;
using UniversityWebbAPP.Model;

namespace UniversityWebbAPP.Ui
{
    public partial class StudentEntry : System.Web.UI.Page
    {
        DepartmentManager departmentManager = new DepartmentManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                departmentDropDownList.DataTextField = "Code";
                departmentDropDownList.DataValueField = "DepartmentId";

                departmentDropDownList.DataSource = departmentManager.GetAllDepartment();
                departmentDropDownList.DataBind();

                
            }
          

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            StudentManager studentManager =new StudentManager();
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string regno = regTextBox.Text;
            int departmentId =Convert.ToInt16( departmentDropDownList.SelectedValue);
            Student student =new Student(name,email,phone,regno,departmentId);

            messageLabel.Text = studentManager.SaveStudent(student);


        }

        protected void ShowButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentShow.aspx");
        }

        protected void departmentDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            int departmentId = Convert.ToInt16(departmentDropDownList.SelectedValue);
      Department department=      departmentManager.GetDepartmentById(departmentId);
            departmentLabel.Text = department.Name;

        }

       
    }
}