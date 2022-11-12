using System;
using System.Collections.Generic;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Domain.Entity.Dto
{
    public class QueryEventDto
    {
        public uint IdEvent { get; set; }
        public string Local { get; set; }
        public DateTime? EventDate { get; set; }
        public string Theme { get; set; }
        public int NumberOfParticipants { get; set; }
        public IEnumerable<Batch> Batch { get; set; }
        public IEnumerable<SocialNetwork> SocialNetwork { get; set; }
        public string ImageUrl { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public IEnumerable<SpeakerEvent> SpeakerEvent { get; set; }
    }
}
