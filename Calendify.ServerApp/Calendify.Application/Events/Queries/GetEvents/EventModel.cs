using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Notes.Queries;

namespace Calendify.Application.Events.Queries.GetEventsList
{
    public class EventModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime Created { get; }
        public DateTime Modified { get; set; }
        public List<NoteModel> Notes { get; set; }
    }
}
