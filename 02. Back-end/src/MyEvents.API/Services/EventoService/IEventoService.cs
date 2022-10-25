using MyEvents.API.Domain.Entity.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.API.Services
{
    public interface IEventoService
    {
        Task<IQueryable<Evento>> BuscarTodosEventos();
    }
}
