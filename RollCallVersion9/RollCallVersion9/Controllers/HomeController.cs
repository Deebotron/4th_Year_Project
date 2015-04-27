using DHTMLX.Common;
using DHTMLX.Scheduler;
using DHTMLX.Scheduler.Data;
using RollCallVersion9.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RollCallVersion9.Controllers
{
    public class HomeController : Controller
    {
        private CalendarContext db = new CalendarContext();
        
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()// timetable goes here
        {
                    
            var scheduler = new DHXScheduler(this);
            scheduler.Skin = DHXScheduler.Skins.Flat;
 
            scheduler.Config.first_hour = 8;
            scheduler.Config.last_hour = 20;
 
            scheduler.LoadData = true;
            scheduler.EnableDataprocessor = true;
 
            return View(scheduler);
        }
 
        public ContentResult Data()
        {
            var apps = db.Timetables.ToList();
            return new SchedulerAjaxData(apps);
        }
 
        public ActionResult Save(int? id, FormCollection actionValues)
        {
            var action = new DataAction(actionValues);
 
            try
            {
                var changedEvent = DHXEventsHelper.Bind<Timetable>(actionValues);
                switch (action.Type)
                {
                    case DataActionTypes.Insert:
                        db.Timetables.Add(changedEvent);
                        break;
                    case DataActionTypes.Delete:
                        db.Entry(changedEvent).State = EntityState.Deleted;
                        break;
                    default:// "update"  
                        db.Entry(changedEvent).State = EntityState.Modified;
                        break;
                }
                db.SaveChanges();
                action.TargetId = changedEvent.Id;
            }
            catch (Exception a)
            {
                action.Type = DataActionTypes.Error;
            }
 
            return (new AjaxSaveResponse(action));
        }
 
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}