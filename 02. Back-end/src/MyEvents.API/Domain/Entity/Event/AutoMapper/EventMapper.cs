﻿using AutoMapper;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Domain.Entity.AutoMapper
{
    public class EventMapper : Profile
    {
        public EventMapper()
        {
            CreateMap<Event, EventDto>().ReverseMap();
        }
    }
}
