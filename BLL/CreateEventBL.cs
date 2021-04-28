
using Shared;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BL
    {
    public class CreateEventBL
        {
        public bool CreateEvent(Event evt)
            {

            IEnumerable<Event> events = new AllEventsBL().GetEvents;


            var queryTitle = (from e in events
                              where e.Title.Equals(evt.Title, StringComparison.OrdinalIgnoreCase)
                              select e).ToList().Count;
            if (queryTitle == 0)
                {
                List<Invitation> invitations = new List<Invitation>();

                if (evt.InviteByEmail != null)
                    {
                    var invited = evt.InviteByEmail.Split(',');
                    Invitation invitation = new Invitation();
                    if (invited != null)
                        {


                        foreach (var item in invited)
                            {
                            invitation.Email = item;
                            invitation.EventId = evt.EventId;
                            }

                        invitations.Add(invitation);
                        }
                    }
                new CreateEventDAL().CreateEvent(evt, invitations);

                return true;
                }
            else
                {
                return false;
                }
            }
        }
    }