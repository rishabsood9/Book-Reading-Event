using System;
using Shared;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace DAL
    {
    public class EditEventDAL
        {
        public bool EditEvent(Event evt, List<Invitation> invitations)
            {
            using (BookReadingContext context = new BookReadingContext())
                {

                var result = (from i in context.Invitations
                              where i.EventId == evt.EventId
                              select i);

                context.Invitations.RemoveRange(result.ToList());
                
               
                foreach (var item in invitations)
                    {
                    item.EventId = evt.EventId;
                    context.Invitations.Add(item);
                    }
                context.SaveChanges();


                context.Entry(evt).State = EntityState.Modified;

                context.SaveChanges();
                 return true;
                    
               
                }
            }
        }
    }
