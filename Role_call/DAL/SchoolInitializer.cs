﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Role_call.Models;

namespace Role_call.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{ID ="X00095250",FirstName="Stephen",LastName="Begley", AttendanceDate=DateTime.Parse("2015-04-01")},
            new Student{ID ="X00095251",FirstName="Thomas",LastName="Jones",AttendanceDate=DateTime.Parse("2015-02-01")},
            new Student{ID ="X00095252",FirstName="Gary",LastName="Curran",AttendanceDate=DateTime.Parse("2015-04-01")},
            new Student{ID ="X00095253",FirstName="Cliff",LastName="Browne",AttendanceDate=DateTime.Parse("2015-04-01")},
            new Student{ID ="X00095254",FirstName="John",LastName="Diez-Daly",AttendanceDate=DateTime.Parse("2015-08-01")},
            new Student{ID ="X00095255",FirstName="Harry",LastName="Kane",AttendanceDate=DateTime.Parse("2015-02-01")},
            new Student{ID ="X00095256",FirstName="David",LastName="Ginola",AttendanceDate=DateTime.Parse("2015-02-01")},
            new Student{ID ="X00095257",FirstName="Ryan",LastName="Mason",AttendanceDate=DateTime.Parse("2015-08-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Software Development",Credits=3,},
            new Course{CourseID=4022,Title="Computational Theory",Credits=3,},
            new Course{CourseID=4041,Title="Enterprise Application Architecture",Credits=3,},
            new Course{CourseID=1045,Title="Databases",Credits=4,},
            new Course{CourseID=3141,Title="Social Media Analysis",Credits=4,},
            new Course{CourseID=2021,Title="Web Deveolpment",Credits=3,},
            new Course{CourseID=2042,Title="Networking",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            //this is for enrolling a student on a course
            var Attendances = new List<Attendance>
            {
            new Attendance{StudentID="x00095250",CourseID=1050,Year=Year.First},
            new Attendance{StudentID="x00095252",CourseID=4022,Year=Year.Fourth},
            new Attendance{StudentID="x00095253",CourseID=4041,Year=Year.Fourth},
            //new Attendance{StudentID=2,CourseID=1045,Year=Year.First},
            //new Attendance{StudentID=2,CourseID=3141,Year=Year.Third},
            //new Attendance{StudentID=2,CourseID=2021,Year=Year.Second},
            //new Attendance{StudentID=3,CourseID=1050,Year=Year.First},
            //new Attendance{StudentID=4,CourseID=1050,Year=Year.First},
            //new Attendance{StudentID=4,CourseID=4022,Year=Year.Fourth},
            //new Attendance{StudentID=5,CourseID=4041,Year=Year.Fourth},
            //new Attendance{StudentID=6,CourseID=1045, Year=Year.First},
            //new Attendance{StudentID=7,CourseID=3141,Year=Year.Third},
            };
            Attendances.ForEach(s => context.Attendances.Add(s));
            context.SaveChanges();
        }
    }
}