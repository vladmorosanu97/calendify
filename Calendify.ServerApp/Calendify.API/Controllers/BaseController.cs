using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}