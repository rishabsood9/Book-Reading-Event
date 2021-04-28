using System;
using AutoMapper;
using MVCAssignment.Models;
using Shared;
using System.Collections.Generic;

namespace MVCAssignment.Helper
    {
    public class EventModelToEventHelper
        {

        public Event EventModelToEventMapping(EventModel e)
            {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<EventModel, Event>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = e;

            var destination = iMapper.Map<EventModel, Event>(source);
            return destination;
            }

        public IEnumerable<Event> GetEvent(IEnumerable<EventModel> eventModels)
            {
            List<Event> events = new List<Event>();
            foreach (var item in eventModels)
                {
                events.Add(EventModelToEventMapping(item));
                }
            return events;

            }
        }
    }