using System;
using System.Collections.Generic;
using System.Text;

namespace Calendify.Application.Notes.Queries
{
    public class NoteModel
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public string Content { get; set; }
    }
}
