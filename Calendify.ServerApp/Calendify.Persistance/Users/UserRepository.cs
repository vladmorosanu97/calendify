using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calendify.Application.Interfaces.Persistence;
using Calendify.Domain.Users;
using Calendify.Persistence.Shared;
using CSharpFunctionalExtensions;

namespace Calendify.Persistence.Users
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        private readonly IDatabaseContext _databaseContext;

        public UserRepository(IDatabaseContext databaseContext) : base(databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Result CheckDuplicateEmail(string email)
        {
            var user = _databaseContext.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                return Result.Failure("Email already exists");
            }
            return Result.Ok();
        }
    }
}
