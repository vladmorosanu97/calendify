using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Interfaces.Application;
using Calendify.Application.Users.Commands;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Users.Queries.ValidateUserEmail
{
    public class CheckDuplicateEmailQuery: IQuery<Result>
    {
        public Email Email { get; }

        public CheckDuplicateEmailQuery(Email email)
        {
            Email = email;
        }
    }
}
