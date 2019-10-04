using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calendify.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors(PolicyName = "AllowAllHeaders")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult FromResult(Result result)
        {
            return result.IsSuccess ? Ok() : Error(result.Error);
        }

        protected IActionResult Error(string errorMessage)
        {
            return BadRequest(errorMessage);
        }

        protected IActionResult FromResultCreated(Result result)
        {
            return result.IsSuccess ?  StatusCode(201) : Error(result.Error);
        }
    }
}