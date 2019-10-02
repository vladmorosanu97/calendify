using System;
using System.Collections.Generic;
using System.Text;

namespace Calendify.Application.Events.Queries.GetEventsList
{
    public sealed class GetEventsQuery : IQuery<List<EventModel>>
    {
        public DateTime StartDate { get;  }
        public DateTime EndDate { get; }
        public GetEventsQuery(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
