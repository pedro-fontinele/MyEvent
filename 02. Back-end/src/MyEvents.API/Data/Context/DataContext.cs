using Microsoft.EntityFrameworkCore;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Evento> Cad_Eventos { get; set; }
    }
}
