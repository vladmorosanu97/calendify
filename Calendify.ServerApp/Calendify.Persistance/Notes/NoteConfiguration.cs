using System;
using Calendify.Domain.Notes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Calendify.Persistence.Notes
{
    public class NoteConfiguration: IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Content).HasMaxLength(2048);
            builder.Property(a => a.Created).HasDefaultValueSql("getdate()");
            builder.Property(a => a.Modified).HasDefaultValueSql("getdate()");
            builder.HasOne(a => a.Event)
                .WithMany(a => a.Notes)
                .HasForeignKey(a => a.EventId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
