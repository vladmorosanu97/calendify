using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Interfaces.Application;
using Calendify.Application.Interfaces.Persistence;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Users.Queries.ValidateUserEmail
{
    public class CheckDuplicateEmailQueryHandler: IQueryHandler<CheckDuplicateEmailQuery, Result>
    {
        private readonly IUserRepository _userRepository;

        public CheckDuplicateEmailQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Result Handle(CheckDuplicateEmailQuery query)
        {
            Result result = _userRepository.CheckDuplicateEmail(query.Email);
            return result;
        }
    }
}
