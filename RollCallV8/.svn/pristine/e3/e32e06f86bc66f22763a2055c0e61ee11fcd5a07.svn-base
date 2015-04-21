using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RollCallV8.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }


        public Grade? Grade { get; set; }


        //navigation properties
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
