using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendify.Application.Interfaces.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calendify.API.Controllers
{
    public class EventsController : BaseController
    {
        private readonly IEventRepository _eventRepository;

        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            var startDate = DateTime.Now.AddDays(-1);
            var endDate = startDate.AddDays(2);
            var events = _eventRepository.GetEvents(startDate, endDate);
            return Ok(events);
        }
    }
}