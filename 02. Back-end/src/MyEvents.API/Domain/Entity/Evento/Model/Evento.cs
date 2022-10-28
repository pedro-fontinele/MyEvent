using System.ComponentModel.DataAnnotations;

namespace MyEvents.API.Domain.Entity.Model
{
    public class Evento
    {
        [Key]
        public uint IdEvento { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdParticipantes { get; set; }
        public string Lote { get; set; }
        public string ImagemUrl { get; set; }
    }
}
