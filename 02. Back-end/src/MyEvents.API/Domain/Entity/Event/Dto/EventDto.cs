using System;
using System.Collections.Generic;

namespace MyEvents.API.Domain.Entity.Dto
{
    public class EventDto
    {
        public uint IdEvent { get; set; }
        public string Local { get; set; }
        public string EventDate { get; set; }
        public string Theme { get; set; }
        public uint NumberOfParticipants { get; set; }
        public string ImageUrl { get; set; }
        public uint Telephone { get; set; }
        public string Email { get; set; }
        public IEnumerable<BatchDto> Batch { get; set; }
        public IEnumerable<SocialNetworkDto> SocialNetwork { get; set; }
        public IEnumerable<SpeakerEventDto> SpeakerEvent { get; set; }
    }
}
