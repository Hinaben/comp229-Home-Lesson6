namespace comp229_Home_Lesson6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Enrollments
    {
        [Key]
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public int Grade { get; set; }

        public virtual Courses Courses { get; set; }

        public virtual Students Students { get; set; }
    }
}
