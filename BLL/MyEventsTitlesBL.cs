using System.Collections.Generic;
using Shared;
using DAL;

namespace BL
    {
    public class MyEventsBL
        {
        public IEnumerable<Event> GetMyEvents(string userName)
            {
           
                MyEventsDAL getMyEventsDAL = new MyEventsDAL();

                IEnumerable<Event> myEvents = getMyEventsDAL.GetMyEvents(userName);
                
                return myEvents;
                
            }

        }
    }
