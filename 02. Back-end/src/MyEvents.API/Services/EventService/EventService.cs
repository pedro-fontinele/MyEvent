using System.Threading.Tasks;
using MyEvents.API.Data.Repository;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<Event[]> GetAllEventsAsync()
        {
            return await _eventRepository.GetAllEventsAsync();
        }
    }
}
