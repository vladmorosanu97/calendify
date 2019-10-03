using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Common;
using Calendify.Domain.Events;

namespace Calendify.Domain.Notes
{
    public class Note: IEntity
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long EventId { get; set; }
        public Event  Event  { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
