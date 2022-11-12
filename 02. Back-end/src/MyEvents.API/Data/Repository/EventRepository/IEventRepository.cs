using System.Threading.Tasks;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public interface IEventRepository
    {
        Task<Event[]> GetAllEventsAsync ();
        Task<Event> GetEventsByIdAsync (uint id);
        Task<Event[]> GetEventsByThemeAsync (string theme);
    }
}
