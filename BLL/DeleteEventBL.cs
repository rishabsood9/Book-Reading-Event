using DAL;
namespace BL
    {
    public class DeleteEventBL
        {
             public void DeleteEvent(int eventId)
            {
            DeleteEventDAL deleteEvent = new DeleteEventDAL();
            deleteEvent.DeleteEvent(eventId);
            }
        }
    }
