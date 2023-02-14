using System.Collections.Generic;
using System.Threading.Tasks;
using MyEvents.API.Domain.Entity.Dto;

namespace MyEvents.API.Services
{
    public interface IEventService
    {
        // Actions
        Task<EventDto> InsertEvents (EventDto eventModel);
        Task<EventDto> UpdateEvents (uint idEvent, EventDto eventModel);
        Task<EventDto> DeleteEvents (uint idEvent);
        Task<EventDto> DeleteAllEvents ();

        // Consult
        Task<List<EventDto>> GetAllEvents();
        Task<EventDto> GetEventsById(uint idEvent);
        Task<List<EventDto>> GetEventsByTheme(string theme);
    }
}
