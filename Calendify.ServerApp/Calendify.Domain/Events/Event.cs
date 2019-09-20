using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Common;
using Calendify.Domain.Notes;

namespace Calendify.Domain.Events
{
    public class Event: IEntity
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime Created { get; }
        public DateTime Modified { get; set; }
        public List<Note> Notes { get; set; }
    }
}
