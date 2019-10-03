using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Interfaces.Persistence;
using Calendify.Domain.Users;
using Calendify.Persistence.Shared;

namespace Calendify.Persistence.Users
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(IDatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
