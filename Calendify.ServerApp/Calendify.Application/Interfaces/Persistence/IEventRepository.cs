using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Events.Queries.GetEventsList;
using Calendify.Domain.Events;

namespace Calendify.Application.Interfaces.Persistence
{
    public interface IEventRepository: IRepository<Event>
    {
        List<Event> GetEvents(DateTime startDate, DateTime endDate);
    }
}
