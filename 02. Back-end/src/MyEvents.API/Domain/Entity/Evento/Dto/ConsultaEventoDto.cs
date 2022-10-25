using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.API.Domain.Entity.Dto
{
    public class ConsultaEventoDto
    {
        public uint IdEvento { get; private set; }
        public string Local { get; private set; }
        public string DataEvento { get; private set; }
        public string Tema { get; private set; }
        public int QtdParticipantes { get; private set; }
        public string Lote { get; private set; }
        public string ImagemUrl { get; private set; }
    }
}
