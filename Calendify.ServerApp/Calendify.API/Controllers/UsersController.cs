using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendify.Application.Interfaces.Persistence;
using Calendify.Application.Users.Commands;
using Calendify.Application.Users.Commands.RegisterUser;
using Calendify.Application.Users.Queries.ValidateUserEmail;
using Calendify.Application.Utils;
using Calendify.API.Dtos;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calendify.API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly Messages _messages;

        public UsersController(Messages messages)
        {
            _messages = messages;
        }

        [HttpPost]
        public IActionResult RegisterUser(RegisterUserDto registerUserDto)
        {
            var firstName = FirstName.Create(registerUserDto.FirstName);
            var lastName = LastName.Create(registerUserDto.LastName);
            var email = Email.Create(registerUserDto.Email);
            var password = Password.Create(registerUserDto.Password);
            Result resultValidation = Result.Combine(firstName, lastName, email, password);
            if (resultValidation.IsFailure)
            {
                return Error(resultValidation.Error);
            }

            var query = new CheckDuplicateEmailQuery((Application.Users.Queries.Email) email.Value.Value);
            Result resultQuery = _messages.Dispatch(query);
            if (resultQuery.IsFailure)
            {
                return Error(resultQuery.Error);
            }

            var command = new RegisterUserCommand(firstName.Value, lastName.Value, email.Value,
                password.Value);
            Result result = _messages.Dispatch(command);
            return FromResultCreated(result);
        }
    }
}