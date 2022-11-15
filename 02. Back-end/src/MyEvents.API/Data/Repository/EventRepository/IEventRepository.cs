using System.Threading.Tasks;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public interface IEventRepository
    {
        // Actions
        Task InsertEventsAsync (Event eventModel);
        Task UpdateEventsAsync (Event eventModel);
        Task DeleteEventsAsync (Event eventModel);
        Task DeleteAllEventsAsync (Event eventModel);
        Task SaveChangesAsync ();

        // Consult
        Task<Event[]> GetAllEventsAsync ();
        Task<Event> GetEventsByIdAsync (uint idEvent);
        Task<Event[]> GetEventsByThemeAsync (string theme);
    }
}
