using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Common;
using Calendify.Domain.Events;
using Calendify.Domain.Notes;
using Calendify.Domain.Users;
using Calendify.Persistence.Events;
using Calendify.Persistence.Notes;
using Calendify.Persistence.Users;
using Microsoft.EntityFrameworkCore;

namespace Calendify.Persistence.Shared
{
    public sealed class DatabaseContext: DbContext, IDatabaseContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
        }
        public new DbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }

        public void Save()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new NoteConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
