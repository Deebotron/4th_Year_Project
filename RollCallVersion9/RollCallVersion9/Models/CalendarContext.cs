using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RollCallVersion9.Models
{
    public class CalendarContext : DbContext
    {
        // change the connection string before deploying to Azure
        public CalendarContext()
            : base()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
        }
        public System.Data.Entity.DbSet<RollCallVersion9.Models.Timetable> Timetables { get; set; }
    }
}