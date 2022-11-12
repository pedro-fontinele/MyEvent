using AutoMapper;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Domain.Entity
{
    public class EventMapper : Profile
    {
        public EventMapper()
        {
            #region Domain for Dto
            CreateMap<Event, EventDto>();
            CreateMap<Event, QueryEventDto>();
            #endregion

            #region Dto for Domain
            CreateMap<EventDto, Event>();
            CreateMap<QueryEventDto, Event>();
            #endregion
        }
    }
}
