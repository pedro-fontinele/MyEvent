using AutoMapper;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Domain.Entity.AutoMapper
{
    public class SpeakerEventMapper : Profile
    {
        public SpeakerEventMapper()
        {
            CreateMap<SpeakerEvent, SpeakerEventDto>().ReverseMap();
        }
    }
}
