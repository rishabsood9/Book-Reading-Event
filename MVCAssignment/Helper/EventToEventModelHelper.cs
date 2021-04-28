using AutoMapper;
using MVCAssignment.Models;
using Shared;
using System.Collections.Generic;
namespace MVCAssignment.Helper
    {
    public class EventToEventModelHelper
        {
        public EventModel EventToEventModelMapping(Event e)
            {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Event, EventModel>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = e;

            var destination = iMapper.Map<Event, EventModel>(source);
            return destination;
            }

        public IEnumerable<EventModel> GetEventModels(IEnumerable<Event> events)
            {
            List<EventModel> eventModels = new List<EventModel>();
            foreach (var item in events)
                {
                eventModels.Add(EventToEventModelMapping(item));
                }
            return eventModels;

            }
        }
    }
    