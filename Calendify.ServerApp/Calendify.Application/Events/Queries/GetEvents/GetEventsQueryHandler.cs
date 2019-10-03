using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calendify.Application.Interfaces.Application;
using Calendify.Application.Interfaces.Persistence;

namespace Calendify.Application.Events.Queries.GetEventsList
{
    public class GetEventsQueryHandler : IQueryHandler<GetEventsQuery, List<EventModel>>
    {
        private readonly IEventRepository _eventRepository;

        public GetEventsQueryHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }


        public List<EventModel> Handle(GetEventsQuery query)
        {
            var events = _eventRepository.GetEvents(query.StartDate, query.EndDate).Select(e => new EventModel
            {
                Id = e.Id,
                Description = e.Description,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                Title = e.Title,
            });

            return events.ToList();
        }
    }
}