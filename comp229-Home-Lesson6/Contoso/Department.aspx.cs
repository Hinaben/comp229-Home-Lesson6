using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statement required for DB connection
using comp229_Home_Lesson6.Models;
using System.Web.ModelBinding;


namespace comp229_Home_Lesson6
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //only do it for the first page load
            if (!IsPostBack)
            {
                getDepartment();
            }

        }

        private void getDepartment()
        {
            //connect to Entity Framework Database
            using (ContosoContext db = new ContosoContext())
            {
                //query the department data
                var department = (from alldepartment in db.Departments
                                  select alldepartment);
                // bind the resultset to the student grid
                DepartmentGridView.DataSource = department.ToList();
                DepartmentGridView.DataBind();


            }
        }
    }
}