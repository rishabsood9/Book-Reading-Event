using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using DAL;
namespace BL
    {
    public class AllEventsBL
        {
        public IEnumerable<Event> GetEvents
            {
            get
                {
                IEnumerable<Event> events;
                AllEventsDAL getEventsDAL = new AllEventsDAL();

                 events = getEventsDAL.GetEvents;
                 return events;
                }
            }

        }
    }
