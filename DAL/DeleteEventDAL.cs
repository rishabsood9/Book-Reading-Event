using System;
using System.Linq;

namespace DAL
    {
    public class DeleteEventDAL
        {
          public void DeleteEvent(int eventId)
            {
            using (BookReadingContext context = new BookReadingContext())
                {
                var result = (from e in context.Events
                             where e.EventId == eventId
                             select e).ToList().First();

                context.Events.Remove(result);
                context.SaveChanges();
                }
            }
        }
    }
