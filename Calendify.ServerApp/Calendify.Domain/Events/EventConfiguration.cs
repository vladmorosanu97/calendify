using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Notes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Calendify.Domain.Events
{
    public class EventConfiguration: IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).HasMaxLength(512).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(1024).IsRequired();
            builder.HasMany<Note>();
        }
    }
}
