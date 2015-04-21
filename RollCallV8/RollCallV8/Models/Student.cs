using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RollCallV8.Models
{
    public class Student
    {

        public int StudentID { get; set; }

        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Date of enrollment")]
        public DateTime EnrollmentDate { get; set; }

        // public virtual Enrollment Enrollment { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}