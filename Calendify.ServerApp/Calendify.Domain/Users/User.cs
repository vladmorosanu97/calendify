using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Common;

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
    }
}
