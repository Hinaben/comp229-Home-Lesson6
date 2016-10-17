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
    public partial class Studnet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //only do it for the first page load
            if (!IsPostBack)
            {
                getStudents();
            }

        }

        private void getStudents()
        {
            //connect to Entity Framework Database
            using (ContosoContext db = new ContosoContext())
            {
                //query the student data
                var studnets = (from allStudents in db.Students
                                select allStudents);
                // bind the resultset to the student grid
                StudentGridView.DataSource = studnets.ToList();
                StudentGridView.DataBind();


            }
        }

        protected void StudentGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //get selected row
            int selectedRow = e.RowIndex;

            //get selected studentID
            int StudentID = Convert.ToInt32(StudentGridView.DataKeys[selectedRow].Values["StudentID"]);

            //use EF & Linq to find the selected student in the DB and remove it
            using (ContosoContext db = new ContosoContext())
            {
                // create object ot the student clas and store the query inside of it
                Student deletedStudent = (from studentRecords in db.Students
                                          where studentRecords.StudentID == StudentID
                                          select studentRecords).FirstOrDefault();

                // remove the selected student from the db
                db.Students.Remove(deletedStudent);

                // save my changes back to the db
                db.SaveChanges();

                // refresh the grid
                this.getStudents();
            }


        }
    }
}