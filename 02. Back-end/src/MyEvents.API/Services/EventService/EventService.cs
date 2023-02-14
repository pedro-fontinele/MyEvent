using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using MyEvents.API.Data.Repository;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _imapper;

        public EventService(IEventRepository eventRepository, IMapper imapper)
        {
            _eventRepository = eventRepository;
            _imapper = imapper;
        }

        public async Task<List<EventDto>> GetAllEvents()
        {
            var returnedEvent = await _eventRepository.GetAllEvents();
            return _imapper.Map<List<EventDto>>(returnedEvent);
        }

        public async Task<EventDto> GetEventsById(uint idEvent)
        {
            var returnedEvent = await _eventRepository.GetEventsById(idEvent);
            return _imapper.Map<EventDto>(returnedEvent);
        }

        public async Task<List<EventDto>> GetEventsByTheme(string theme)
        {
            if (!string.IsNullOrEmpty(theme))
            {
                var returnedEvent = await _eventRepository.GetEventsByTheme(theme);
                return _imapper.Map<List<EventDto>>(returnedEvent);
            }
            return null;
        }

        public async Task<EventDto> InsertEvents(EventDto eventDto)
        {
            if (eventDto != null)
            {
                var eventMap = _imapper.Map<Event>(eventDto);
                _eventRepository.InsertEvents(eventMap);
                var returnedEvent = await _eventRepository.GetEventsById(eventMap.IdEvent);
                return _imapper.Map<EventDto>(returnedEvent);
            }
            return null;
        }

        public async Task<EventDto> UpdateEvents(uint idEvent, EventDto eventDto)
        {
            if (eventDto != null)
            {
                var returnedEvent = await _eventRepository.GetEventsById(idEvent);
                if (returnedEvent != null)
                {
                    var eventMap = _imapper.Map<Event>(eventDto);
                    _eventRepository.UpdateEvents(eventMap);
                }
                return _imapper.Map<EventDto>(returnedEvent);
            }
            return null;
        }

        public async Task<EventDto> DeleteEvents(uint idEvent)
        {
            var returnedEvent = await _eventRepository.GetEventsById(idEvent);
            if (returnedEvent != null)
            {
                _eventRepository.DeleteEvents(returnedEvent);
            }
            return null;
        }

        public async Task<EventDto> DeleteAllEvents()
        {
            var returnedEvent = await _eventRepository.GetAllEvents();
            if (returnedEvent != null)
            {
                foreach (var item in returnedEvent)
                {
                    _eventRepository.DeleteEvents(item);
                }
            }
            return null;
        }
    }
}
