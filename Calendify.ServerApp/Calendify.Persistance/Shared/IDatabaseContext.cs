using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Common;
using Calendify.Domain.Events;
using Calendify.Domain.Notes;
using Calendify.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Calendify.Persistence.Shared
{
   public  interface IDatabaseContext
    {
        DbSet<Event> Events { get; set; }
        DbSet<Note> Notes { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<T> Set<T>() where T : class, IEntity;
        void Save();
    }
}
