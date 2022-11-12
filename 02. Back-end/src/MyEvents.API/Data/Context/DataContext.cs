using Microsoft.EntityFrameworkCore;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Event> Event { get; set; }
        public DbSet<Batch> Batch { get; set; }
        public DbSet<Speaker> Speaker { get; set; }
        public DbSet<SpeakerEvent> SpeakerEvent { get; set; }
        public DbSet<SocialNetwork> SocialNetwork { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpeakerEvent>().HasKey(e => new {e.IdEvent, e.IdSpeaker});
        }
    }
}
