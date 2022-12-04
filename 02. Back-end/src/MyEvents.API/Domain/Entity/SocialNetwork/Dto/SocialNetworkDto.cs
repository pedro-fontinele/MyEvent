namespace MyEvents.API.Domain.Entity.Dto
{
    public class SocialNetworkDto
    {
        public uint IdSocialNetwork { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public uint? IdEvent { get; set; }
        public EventDto EventDto { get; set; }
        public uint? IdSpeaker { get; set; }
        public SpeakerDto SpeakerDto { get; set; }
    }
}
