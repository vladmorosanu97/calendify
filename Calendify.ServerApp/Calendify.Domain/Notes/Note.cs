using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Common;

namespace Calendify.Domain.Notes
{
    public class Note: IEntity
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public string Content { get; set; }
    }
}
