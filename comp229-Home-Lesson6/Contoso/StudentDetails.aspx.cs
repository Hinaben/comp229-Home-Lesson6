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
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //redirect bk to student page
            Response.Redirect("~/Contoso/Students.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            //connect to Entity Framework Database
            using (ContosoContext db = new ContosoContext())
            {
                // create a new student
                Student newStudent = new Student();
                int studentID = 0;


                //get student info from the form
                newStudent.LastName = LastNameTextBox.Text;
                newStudent.FirstMidName = FirstNameTextBox.Text;
                newStudent.EnrollmentDate = Convert.ToDateTime(EnrollmentDateTextBox.Text);


                if (studentID == 0)
                {
                    //add new student 
                    db.Students.Add(newStudent);
                }

                //save changes
                db.SaveChanges();


                //redirect bk to student page
                Response.Redirect("~/Contoso/Students.aspx");
            }
        }
    }
}