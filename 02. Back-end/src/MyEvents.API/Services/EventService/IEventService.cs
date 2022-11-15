using System.Threading.Tasks;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Services
{
    public interface IEventService
    {
        // Actions
        Task<Event> InsertEventsAsync (Event eventModel);
        Task<Event> UpdateEventsAsync (uint idEvent, Event eventModel);
        Task<Event> DeleteEventsAsync (uint idEvent);
        Task<Event> DeleteAllEventsAsync ();

        // Consult
        Task<Event[]> GetAllEventsAsync();
        Task<Event> GetEventsByIdAsync(uint idEvent);
        Task<Event[]> GetEventsByThemeAsync(string theme);
    }
}
