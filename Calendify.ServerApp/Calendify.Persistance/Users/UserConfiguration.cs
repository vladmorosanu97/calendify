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
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Email).HasMaxLength(512).IsRequired();
            builder.Property(u => u.FirstName).HasMaxLength(512).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(512).IsRequired();
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.Created).HasDefaultValueSql("getdate()");
            builder.Property(u => u.Modified).HasDefaultValueSql("getdate()");
        }
    }
}
