using Shared;
using DAL;
using System.Collections.Generic;

namespace BL
    {
    public class EditEventBL
        {
        public bool EditEvent(Event evt )
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
            EditEventDAL editEvent = new EditEventDAL();

            return editEvent.EditEvent(evt,invitations) ? true : false;

            }

        }
    }
