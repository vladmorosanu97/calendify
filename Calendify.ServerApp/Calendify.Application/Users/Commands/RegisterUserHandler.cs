using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Interfaces.Application;
using Calendify.Application.Interfaces.Persistence;
using Calendify.Domain.Users;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Users.Commands
{
    public class RegisterUserHandler: ICommandHandler<RegisterUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public RegisterUserHandler(IUserRepository  userRepository)
        {
            _userRepository = userRepository;
        }
        public Result Handle(RegisterUserCommand command)
        {
            var user = new User(command.FirstName, command.LastName, command.Email, command.Password);
            _userRepository.Add(user);
            return Result.Ok();
        }


    }
}
