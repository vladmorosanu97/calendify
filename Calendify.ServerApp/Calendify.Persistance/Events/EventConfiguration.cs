using System;
using Calendify.Domain.Events;
using Calendify.Domain.Notes;
using Calendify.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Calendify.Persistence.Events
{
    public class EventConfiguration: IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).HasMaxLength(512).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(1024).IsRequired();
            builder.Property(a => a.Created).HasDefaultValueSql("getdate()");
            builder.Property(a => a.Modified).HasDefaultValueSql("getdate()");
            builder.HasOne(a => a.User)
                .WithMany(a => a.Events)
                .HasForeignKey(a => a.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
