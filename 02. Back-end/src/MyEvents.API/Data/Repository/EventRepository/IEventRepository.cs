using System.Threading.Tasks;
using System.Collections.Generic;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public interface IEventRepository
    {
        // Actions
        void InsertEvents (Event eventModel);
        void UpdateEvents (Event eventModel);
        void DeleteEvents (Event eventModel);

        // Consult
        Task<List<Event>> GetAllEvents ();
        Task<Event> GetEventsById (uint idEvent);
        Task<List<Event>> GetEventsByTheme (string theme);
    }
}
