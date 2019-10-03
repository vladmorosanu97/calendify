using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calendify.Application.Interfaces.Persistence;
using Calendify.Domain.Events;
using Calendify.Persistence.Shared;

namespace Calendify.Persistence.Events
{
    public class EventRepository: Repository<Event>,
        IEventRepository
    {
        private readonly IDatabaseContext _databaseContext;

        public EventRepository(IDatabaseContext databaseContext) : base(databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<Event> GetEvents(DateTime startDate, DateTime endDate)
        {
            return _databaseContext.Events.Where(e => e.StartDate >= startDate && e.EndDate <= endDate).ToList();
        }
    }
}
