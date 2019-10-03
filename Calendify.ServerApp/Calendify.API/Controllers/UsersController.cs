using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendify.Application.Interfaces.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calendify.API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}