using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Role_call.Models
{
    public class Student
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public DateTime AttendanceDate { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}