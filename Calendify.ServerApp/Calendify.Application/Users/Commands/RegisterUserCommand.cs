using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Interfaces.Application;

namespace Calendify.Application.Users.Commands
{
    public class RegisterUserCommand: ICommand
    {
        public long Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Password { get; }
        public string Email { get; }

        public RegisterUserCommand(long id, string email, string password, string firstName, string lastName)
        {
            Id = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
