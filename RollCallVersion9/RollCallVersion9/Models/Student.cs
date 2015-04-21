using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RollCallVersion9.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // public virtual Enrollment Enrollment { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}