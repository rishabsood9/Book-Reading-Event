using Shared;
using DAL;
namespace BL
    {
      public class EventBL
        {

          public Event GetEvent(int eventId)
            {
            return new EventDAL().GetEvent(eventId);
            }
        }
    }
