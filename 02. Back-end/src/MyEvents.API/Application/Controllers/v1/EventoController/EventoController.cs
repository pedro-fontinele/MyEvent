using Microsoft.AspNetCore.Mvc;
using MyEvents.API.Domain.Entity.Model;
using MyEvents.API.Services;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.API.Application.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoService _eventoService;

        public EventoController(IEventoService eventoService)
        {
            _eventoService = eventoService;
        }

        [HttpGet]
        public async Task<IQueryable<Evento>> Get()
        {
            var evento = await _eventoService.BuscarTodosEventos();
            return evento;
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
