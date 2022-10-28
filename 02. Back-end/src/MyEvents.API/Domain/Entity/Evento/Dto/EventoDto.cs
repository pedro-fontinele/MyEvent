using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.API.Domain.Entity.Dto
{
    public class EventoDto
    {
        public uint IdEvento { get; set; }
        public string Local { get;  set; }
        public string DataEvento { get;  set; }
        public string Tema { get;  set; }
        public int QtdParticipantes { get;  set; }
        public string Lote { get;  set; }
        public string ImagemUrl { get;  set; }
    }
}
