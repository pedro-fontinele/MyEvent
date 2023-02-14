using System.Collections.Generic;

namespace MyEvents.API.Domain.Entity.Dto
{
    public class SpeakerDto
    {
        public uint IdSpeaker { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public IEnumerable<SocialNetworkDto> SocialNetwork { get; set; }
        public IEnumerable<SpeakerEventDto> SpeakerEvent { get; set; }
    }
}
