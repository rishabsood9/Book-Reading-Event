
using System.Collections.Generic;
using System.Web.Mvc;
using BL;
using Shared;
using System.Linq;
using System;
using MVCAssignment.Models;
using MVCAssignment.Helper;

namespace MVCAssignment.Controllers
    {

    public class HomeController : Controller
        {

        public ActionResult About()
            {
            IEnumerable<Event> upcomingEvents;
            IEnumerable<Event> events = new AllEventsBL().GetEvents;
            IEnumerable<Event> missedEvents;
            if (User.Identity.IsAuthenticated)
                {
                upcomingEvents = events.Where(e => (e.Date > DateTime.Now.Date) || ((e.Date == DateTime.Now.Date) && (e.Date.TimeOfDay > DateTime.Now.TimeOfDay))).ToList();
                upcomingEvents = upcomingEvents.Where(e => (e.Type==EventType.PRIVATE &&e.UserId == User.Identity.Name) ||(e.Type==EventType.PUBLIC)).ToList();
                missedEvents = events.Where(e => (e.Date < DateTime.Now.Date) || ((e.Date == DateTime.Now.Date) && (e.Date.TimeOfDay < DateTime.Now.TimeOfDay))).ToList();
                missedEvents = missedEvents.Where(e => (e.Type == EventType.PRIVATE && e.UserId == User.Identity.Name) || (e.Type == EventType.PUBLIC)).ToList();
                }
            else
                {
                events = events.Where(x => x.Type == EventType.PUBLIC);
                missedEvents = events.Where(e => (e.Date < DateTime.Now.Date) || ((e.Date == DateTime.Now.Date) && (e.Date.TimeOfDay < DateTime.Now.TimeOfDay))).ToList();
                //missedEvents = missedEvents.Where(e => e.Type == EventType.PUBLIC).ToList();
                upcomingEvents = events.Where(e => (e.Date > DateTime.Now.Date) || ((e.Date == DateTime.Now.Date) && (e.Date.TimeOfDay > DateTime.Now.TimeOfDay))).ToList();
                upcomingEvents = upcomingEvents.Where(e => e.Type == EventType.PUBLIC).ToList();

                }



            if (User.Identity.IsAuthenticated)
                {
                }
            else
                {
               
                }
            List<IEnumerable<EventModel>> eventModels = new List<IEnumerable<EventModel>>();
            eventModels.Add(new EventToEventModelHelper().GetEventModels(missedEvents));
            eventModels.Add(new EventToEventModelHelper().GetEventModels(upcomingEvents));

            return View(eventModels);
            }


        }
    }