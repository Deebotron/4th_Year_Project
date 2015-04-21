using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RollCallV8.Models
{
    public class Lecture
    {
        public int LectureId { get; set; }
        public string LectureName { get; set; }
        public DateTime LectureDate { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int CourseId { get; set; }

       

        //check box for attendance
        public bool attended { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }

        public virtual Enrollment Enrollments { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}