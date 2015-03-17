using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Role_call.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Must enter a student ID eg. X000123456")]
        [StringLength(15)]
        // [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage=("ID must begin with X") )]
        public string ID { get; set; }

        [Required(ErrorMessage = ("You must enter a Last Name"))]
        [StringLength(50)]
        public string LastName { get; set; }

        //[Column("FirstName")]
        [Required(ErrorMessage = ("You must enter a first name"))]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "FirstName")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


        //must look at this for recording the attendance
        public DateTime AttendanceDate { get; set; }

        //[Required(ErrorMessage= ("You must enter an email address"))]
        //public EmailService email { get; set; }



        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}