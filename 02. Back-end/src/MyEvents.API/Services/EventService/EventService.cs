using System.Threading.Tasks;
using MyEvents.API.Data.Repository;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;        

        public EventService (IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<Event[]> GetAllEventsAsync()
        {
            return await _eventRepository.GetAllEventsAsync();
        }

        public async Task<Event> GetEventsByIdAsync(uint idEvent)
        {
            if (idEvent == 0) return null;

            return await _eventRepository.GetEventsByIdAsync(idEvent);
        }

        public async Task<Event[]> GetEventsByThemeAsync(string theme)
        {
            if (string.IsNullOrEmpty(theme)) return null;

            return await _eventRepository.GetEventsByThemeAsync(theme);
        }

        public async Task<Event> InsertEventsAsync (Event eventModel)
        {
             if (string.IsNullOrEmpty(eventModel.ToString())) return null;   

             await _eventRepository.InsertEventsAsync(eventModel);
             await _eventRepository.SaveChangesAsync();
             return await _eventRepository.GetEventsByIdAsync(eventModel.IdEvent);
        }

        public async Task<Event> UpdateEventsAsync (uint idEvent, Event eventModel)
        {
            if (idEvent == 0 || string.IsNullOrEmpty(eventModel.ToString())) return null;

            var returnedEvent = await _eventRepository.GetEventsByIdAsync(idEvent);
            if (returnedEvent.IdEvent == idEvent)
            {
                await _eventRepository.UpdateEventsAsync(eventModel);
                await _eventRepository.SaveChangesAsync();
                return eventModel;
            }
            return null;
        }

        public async Task<Event> DeleteEventsAsync (uint idEvent)
        {
            if (idEvent == 0) return null;

            var returnedEvent = await _eventRepository.GetEventsByIdAsync(idEvent);
            if (returnedEvent.IdEvent == idEvent)
            {
                await _eventRepository.DeleteEventsAsync(returnedEvent);
                await _eventRepository.SaveChangesAsync();
            }
            return null;
        }

        public async Task<Event> DeleteAllEventsAsync ()
        {
            var returnedEvent = await _eventRepository.GetAllEventsAsync();
            if (!string.IsNullOrEmpty(returnedEvent.ToString()))
            {
                foreach (var item in returnedEvent)
                {
                    await _eventRepository.DeleteAllEventsAsync(item);
                    await _eventRepository.SaveChangesAsync();
                }
                return null;
            }
            return null;
        }
    }
}
