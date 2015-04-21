using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RollCallVersion9.Models
{
    public class Lecture
    {
        public int LectureId { get; set; }

        [Display(Name="Lecture Name")]
        public string LectureName { get; set; }

        [Display(Name = "Lecture Date")]
        public DateTime LectureDate { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int CourseId { get; set; }

        // public int StudentID { get; set; }

        //check box for attendance
        public bool attended { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }

        public virtual Enrollment Enrollments { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}