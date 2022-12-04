using AutoMapper;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Domain.Entity.AutoMapper
{
    public class SpeakerMapper : Profile
    {
        public SpeakerMapper()
        {
            CreateMap<Speaker, SpeakerDto>().ReverseMap();
        }
    }
}
