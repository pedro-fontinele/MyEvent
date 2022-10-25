using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.API.Data.Repositores
{
    public interface IEventoRepositore
    {
        Task<IQueryable<Evento>> BuscarTodosEventos();
    }
}
