using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Role_call.Models
{
    public enum Year
    {
        First, Second, Third, Fourth
    }

    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Year Year { get; set; }

        public DateTime attendanceDateTime { get; set; }

        // is the correct?????
        public List<Attendance> Attendances { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}