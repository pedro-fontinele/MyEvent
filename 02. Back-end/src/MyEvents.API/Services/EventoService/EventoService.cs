using MyEvents.API.Data.Repositores;
using MyEvents.API.Domain.Entity.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.API.Services
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepositore _eventoRepositore;

        public EventoService(IEventoRepositore eventoRepositore)
        {
            _eventoRepositore = eventoRepositore;
        }

        public async Task<IQueryable<Evento>> BuscarTodosEventos()
        {
            return await _eventoRepositore.BuscarTodosEventos();
        }
    }
}
