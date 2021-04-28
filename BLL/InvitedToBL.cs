using System.Collections.Generic;
using System.Linq;
using DAL;
using Shared;

namespace BL
    {
    public class InvitedToBL
        {

        public IEnumerable<Event> GetInvitedTo(string userEmail)
            {
            
                InvitedToDAL getMissedEventsDAL = new InvitedToDAL();

                IEnumerable<Event> invitedToEvents = getMissedEventsDAL.GetInvitedTo(userEmail);
               

                var query = from e in invitedToEvents
                            select e;

                if (query != null)
                    {
                    invitedToEvents = query.ToList();
                    }
           
                return invitedToEvents;
                
            }
        }

    }
