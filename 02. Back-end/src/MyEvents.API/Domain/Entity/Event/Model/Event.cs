using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyEvents.API.Domain.Entity.Model
{
    public class Event
    {
        [Key]
        public uint IdEvent { get; set; }
        public string Local { get; set; }
        public string EventDate { get; set; }
        public string Theme { get; set; }
        public uint NumberOfParticipants { get; set; }
        public string ImageUrl { get; set; }
        public uint Telephone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Batch> Batch { get; set; }
        public IEnumerable<SocialNetwork> SocialNetwork { get; set; }
        public IEnumerable<SpeakerEvent> SpeakerEvent { get; set; }
    }
}
