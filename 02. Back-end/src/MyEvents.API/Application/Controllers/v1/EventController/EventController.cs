using MyEvents.API.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Application.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult> Get ()
        {
            var returnedEvent = await _eventService.GetAllEventsAsync();
            return Ok(returnedEvent);
        }

        [HttpGet("id/{idEvent}")]
        public async Task<IActionResult> Get (uint idEvent)
        {
            var returnedEvent = await _eventService.GetEventsByIdAsync(idEvent);
            return Ok(returnedEvent);
        }

        [HttpGet("theme/{theme}")]
        public async Task<IActionResult> Get (string theme)
        {
            var returnedEvent = await _eventService.GetEventsByThemeAsync(theme);
            return Ok(returnedEvent);
        }

        [HttpPost]
        public async Task<IActionResult> Post (Event eventModel)
        {
            var returnedEvent = await _eventService.InsertEventsAsync(eventModel);
            return Ok(returnedEvent);
        }

        [HttpPut("id/{idEvent}")]
        public async Task<IActionResult> Put (uint idEvent, Event eventModel)
        {
            var returnedEvent = await _eventService.UpdateEventsAsync(idEvent, eventModel);
            return Ok(returnedEvent);
        }

        [HttpDelete("id/{idEvent}")]
        public async Task<IActionResult> Delete (uint idEvent)
        {
            var returnedEvent = await _eventService.DeleteEventsAsync(idEvent);
            return Ok(returnedEvent);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAll ()
        {
            var returnedEvent = await _eventService.DeleteAllEventsAsync();
            return Ok(returnedEvent);
        }
    }
}
