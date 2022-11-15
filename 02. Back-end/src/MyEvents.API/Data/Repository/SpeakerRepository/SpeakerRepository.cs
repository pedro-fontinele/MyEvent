using System.Linq;
using System.Threading.Tasks;
using MyEvents.API.Data.Context;
using Microsoft.EntityFrameworkCore;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public class SpeakerRepository : ISpeakerRepository
    {
        private readonly DataContext _dataContext;

        public SpeakerRepository (DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add<T>(T Entity) where T : class
        {
            _dataContext.Add(Entity);
        }
        
        public void Update<T>(T Entity) where T : class
        {
            _dataContext.Update(Entity);
        }

        public void Delete<T>(T Entity) where T : class
        {
            _dataContext.Remove(Entity);
        }

        public void DeleteRange<T>(T Entity) where T : class
        {
            _dataContext.RemoveRange(Entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<Speaker[]> GetAllSpeakerAsync()
        {
            IQueryable<Speaker> query = _dataContext.Speaker.AsNoTracking();

            query = query.OrderBy(e => e.IdSpeaker);

            return await query.ToArrayAsync();
        }

        public async Task<Speaker> GetSpeakerByIdAsync(uint id)
        {
            IQueryable<Speaker> query = _dataContext.Speaker.AsNoTracking();

            query = query.OrderBy(e => e.IdSpeaker)
                         .Where(e => e.IdSpeaker == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Speaker[]> GetSpeakerByNameAsync(string name)
        {
            IQueryable<Speaker> query = _dataContext.Speaker.AsNoTracking();

            query = query.OrderBy(e => e.IdSpeaker)
                         .Where(e => e.Name.ToUpper().Contains(name.ToUpper()));

            return await query.ToArrayAsync();
        }
    }
}
