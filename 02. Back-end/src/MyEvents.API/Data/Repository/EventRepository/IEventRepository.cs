using System.Threading.Tasks;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public interface IEventRepository
    {
        // Actions
        void InsertEvents (Event eventModel);
        void UpdateEvents (Event eventModel);
        void DeleteEvents (Event eventModel);
        void DeleteAllEvents (Event eventModel);
        void SaveChanges ();

        // Consult
        Task<Event[]> GetAllEvents ();
        Task<Event> GetEventsById (uint idEvent);
        Task<Event[]> GetEventsByTheme (string theme);
    }
}
