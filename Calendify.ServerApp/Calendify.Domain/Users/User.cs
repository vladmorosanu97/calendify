using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Common;
using Calendify.Domain.Events;

namespace Calendify.Domain.Users
{
    public class User: IEntity
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public List<Event> Events { get; set; }


        protected User()
        {

        }

        public User(string firstName, string lastName, string email, string passwordHash)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            PasswordHash = passwordHash;
        }
    }
}
