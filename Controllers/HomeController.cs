
using FindaPreacher_1_.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FindaPreacher.Controllers
{
    public class HomeController : Controller
    {
         FindaPreacherEntities2 db =new FindaPreacherEntities2();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Event()
        {
            List<Event> e = db.Events.ToList();
            return View(e);
        }
        public ActionResult AddEvent()
        {
            List<Event> eve = db.Events.ToList();

            //List<MinistryType> m = db.MinistryTypes.ToList();
            //ViewBag.MinistryTypeList = new SelectList(m, "MinistryTypeID", "MinistryType1");

            //List<EventHelpService> Help= db.EventHelpServices.ToList();
            //ViewBag.MinistryHelpList = new SelectList(Help, "HelpServiceTypeID", "Message");
            return View(eve);
        }
      [HttpPost]
      public ActionResult AddEvent(Event eve)
        {
            db.Events.Add(eve);
            db.SaveChanges();

            ViewBag.Message = "Successfully Submitted";
            return RedirectToAction("Event");
        }
        public ActionResult Delete(int eid)
        {
            
            
                Event eve = db.Events.ToList().Where(x => x.EventID == eid).FirstOrDefault();

            return View(eve);
            
        }
        

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Event eve = db.Events.Find(id);
            db.Events.Remove(eve);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int eveid)
        {
            Event eve = db.Events.ToList().Where(x => x.EventID == eveid).FirstOrDefault();

            return View(eve);


        }

        [HttpPost]
        public ActionResult Update(Event e)
        {

            db.Events.ToList();
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}