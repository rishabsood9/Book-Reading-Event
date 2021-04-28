using Shared;
using System.Linq;
using System.Collections.Generic;
namespace DAL
    {
     public class EventDAL
        {
             public Event GetEvent(int eventId)
            {
            using (BookReadingContext context = new BookReadingContext())
                {
                  IEnumerable<Event> events = context.Events;
                  Event eventFound = null;
                var query = from evt in events
                            where evt.EventId == eventId
                            select evt;
                if(query!=null)
                    {
                    eventFound = query.ToList().First();
                    }
                return eventFound;
                }
            }
        }
    }
