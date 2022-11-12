using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyEvents.API.Domain.Entity.Model
{
    public class Speaker
    {
        [Key]
        public uint IdSpeaker { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public IEnumerable<SocialNetwork> SocialNetwork { get; set; }
        public IEnumerable<SpeakerEvent> SpeakerEvent { get; set; }
    }
}
