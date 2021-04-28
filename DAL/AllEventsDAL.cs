
using Shared;
using System.Collections.Generic;
using System.Linq;
namespace DAL
    {
    public class AllEventsDAL
        {
           public IEnumerable<Event> GetEvents
            {
            get
                {
                using (BookReadingContext context=new BookReadingContext())
                    {
                    IEnumerable<Event> events = (from e in context.Events
                                                 select e).ToList();
                    return events;
                    }
                }
            }
        }
    }
