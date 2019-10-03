using System;
using Calendify.Domain.Events;
using Calendify.Domain.Notes;
using Calendify.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Calendify.Persistence.Users
{
    public sealed class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Email).HasMaxLength(512).IsRequired();
            builder.Property(c => c.FirstName).HasMaxLength(512).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(512).IsRequired();
            builder.Property(c => c.PasswordHash).IsRequired();
            builder.Property(a => a.Created).HasDefaultValueSql("getdate()");
            builder.Property(a => a.Modified).HasDefaultValueSql("getdate()");
        }
    }
}
