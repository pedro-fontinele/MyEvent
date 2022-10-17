using Microsoft.AspNetCore.Mvc;

namespace MyEvents.API.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Retonar Get";
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
