using AutoMapper;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Domain.Entity
{
    public class EventoMapper : Profile
    {
        public EventoMapper()
        {
            #region Domínio para Dto
            CreateMap<Evento, EventoDto>();
            CreateMap<Evento, ConsultaEventoDto>();
            #endregion

            #region Dto para Domínio
            CreateMap<EventoDto, Evento>();
            CreateMap<ConsultaEventoDto, Evento>();
            #endregion
        }
    }
}
