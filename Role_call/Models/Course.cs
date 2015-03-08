using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Role_call.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
   
    }
}