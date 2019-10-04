using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Interfaces.Application;
using Calendify.Application.Interfaces.Persistence;
using Calendify.Domain.Users;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Users.Commands.RegisterUser
{
    public class RegisterUserCommandHandler: ICommandHandler<RegisterUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterUserCommandHandler(IUserRepository  userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }
        public Result Handle(RegisterUserCommand command)
        {
            var user = new User(command.FirstName, command.LastName, command.Email, command.Password);
            _userRepository.Add(user);
            _unitOfWork.Save();
            return Result.Ok();
        }
    }
}
