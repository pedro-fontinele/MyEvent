using AutoMapper;
using System.Threading.Tasks;
using MyEvents.API.Data.Repository;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _imapper;

        public EventService (IEventRepository eventRepository, IMapper imapper)
        {
            _eventRepository = eventRepository;
            _imapper = imapper;
        }

        public async Task<EventDto[]> GetAllEvents ()
        {
            var returnedEvent = await _eventRepository.GetAllEvents();
            var result = _imapper.Map<EventDto[]>(returnedEvent);
            return result;
        }

        public async Task<EventDto> GetEventsById (uint idEvent)
        {
            if (idEvent > 0)
            {
                var returnedEvent = await _eventRepository.GetEventsById(idEvent);
                if (!string.IsNullOrEmpty(returnedEvent.ToString()))
                {
                    var result = _imapper.Map<EventDto>(returnedEvent);
                    return result;
                }
                return null;
            }
            return null;
        }

        public async Task<EventDto[]> GetEventsByTheme (string theme)
        {
            if (!string.IsNullOrEmpty(theme))
            {
                var returnedEvent = await _eventRepository.GetEventsByTheme(theme);
                var result = _imapper.Map<EventDto[]>(returnedEvent);
                return result;
            }               
            return null;
        }

        public async Task<EventDto> InsertEvents (EventDto eventDto)
        {
            if (!string.IsNullOrEmpty(eventDto.ToString()))
            {
                var eventMap = _imapper.Map<Event>(eventDto);
                _eventRepository.InsertEvents(eventMap);

                var returnedEvent = await _eventRepository.GetEventsById(eventMap.IdEvent);

                var eventDtoMap = _imapper.Map<EventDto>(returnedEvent);
                return eventDtoMap;
            } 
            return null;
        }

        public async Task<EventDto> UpdateEvents (uint idEvent, EventDto eventDto)
        {
            if (!string.IsNullOrEmpty(eventDto.ToString()) && idEvent > 0) 
            {
                var returnedEvent = await _eventRepository.GetEventsById(idEvent);
                if (!string.IsNullOrEmpty(returnedEvent.ToString()))
                {
                    var eventMap = _imapper.Map<Event>(eventDto);
                    _eventRepository.UpdateEvents(eventMap);
                    var eventDtoMap = _imapper.Map<EventDto>(returnedEvent);
                    return eventDtoMap;
                }
                return null;
            }
            return null;
        }

        public async Task<EventDto> DeleteEvents (uint idEvent)
        {
            if (idEvent > 0)
            {
                var returnedEvent = await _eventRepository.GetEventsById(idEvent);
                if (!string.IsNullOrEmpty(returnedEvent.ToString()))
                {
                    _eventRepository.DeleteEvents(returnedEvent);
                }
            }
            return null;
        }

        public async Task<EventDto> DeleteAllEvents ()
        {
            var returnedEvent = await _eventRepository.GetAllEvents();
            if (!string.IsNullOrEmpty(returnedEvent.ToString()))
            {
                foreach (var item in returnedEvent)
                {
                    _eventRepository.DeleteAllEvents(item);
                }
                return null;
            }
            return null;
        }
    }
}
