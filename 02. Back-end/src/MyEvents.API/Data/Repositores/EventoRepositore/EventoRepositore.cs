using Microsoft.EntityFrameworkCore;
using MyEvents.API.Data.Context;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.API.Data.Repositores
{
    public class EventoRepositore : IEventoRepositore
    {
        private readonly DataContext _dataContext;

        public EventoRepositore (DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IQueryable<Evento>> BuscarTodosEventos()
        {
             var query = await _dataContext.Cad_Eventos.ToListAsync();
             return query.AsQueryable();
        }
    }
}
