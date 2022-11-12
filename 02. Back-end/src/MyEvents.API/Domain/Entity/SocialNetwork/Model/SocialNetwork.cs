using System.ComponentModel.DataAnnotations;

namespace MyEvents.API.Domain.Entity.Model
{
    public class SocialNetwork
    {
        [Key]
        public uint IdSocialNetwork { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public uint? IdEvent { get; set; }
        public Event Event { get; set; }
        public uint? IdSpeaker { get; set; }
        public Speaker Speaker { get; set; }
    }
}
