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
        public async Task<Event[]> Get()
        {
            var returnedEvent = await _eventService.GetAllEventsAsync();
            return returnedEvent;
        }

        [HttpGet("{id}")]
        public string Get(uint id)
        {
            return "Retonar Get por id";
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(uint id)
        {
            return "Exemplo de Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Exemplo de Delete";
        }

        [HttpDelete("{id}")]
        public string Delete(uint id)
        {
            return "Exemplo de Delete por id";
        }
    }
}
