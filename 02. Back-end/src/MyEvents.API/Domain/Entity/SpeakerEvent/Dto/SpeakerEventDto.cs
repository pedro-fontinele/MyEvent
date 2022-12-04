namespace MyEvents.API.Domain.Entity.Dto
{
    public class SpeakerEventDto
    {
        public uint IdSpeaker { get; set; }
        public SpeakerDto SpeakerDto { get; set; }
        public uint IdEvent { get; set; }
        public EventDto EventDto { get; set; }
    }
}
