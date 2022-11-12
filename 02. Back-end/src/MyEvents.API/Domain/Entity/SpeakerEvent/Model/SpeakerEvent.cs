using System.ComponentModel.DataAnnotations;

namespace MyEvents.API.Domain.Entity.Model
{
    public class SpeakerEvent
    {
        [Key]
        public uint IdSpeaker { get; set; }
        public Speaker Speaker { get; set; }
        public uint IdEvent { get; set; }
        public Event Event { get; set; }
    }
}
