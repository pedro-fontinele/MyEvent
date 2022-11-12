using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyEvents.API.Data.Context;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public class EventRepository : IEventRepository, IActionsRepository
    {
        private readonly DataContext _dataContext;

        public EventRepository (DataContext dataContext)
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

        public async Task<Event[]> GetAllEventsAsync()
        {
            IQueryable<Event> query = _dataContext.Event.Include(e => e.Batch)
                                                        .Include(e => e.SocialNetwork);

            query = query.OrderBy(e => e.IdEvent);

            return await query.ToArrayAsync();
        }

        public async Task<Event> GetEventsByIdAsync(uint id)
        {
            IQueryable<Event> query = _dataContext.Event.Include(e => e.Batch)
                                                        .Include(e => e.SocialNetwork);

            query = query.OrderBy(e => e.IdEvent)
                         .Where(e => e.IdEvent == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Event[]> GetEventsByThemeAsync(string theme)
        {
            IQueryable<Event> query = _dataContext.Event.Include(e => e.Batch)
                                                        .Include(e => e.SocialNetwork);

            query = query.OrderBy(e => e.IdEvent)
                         .Where(e => e.Theme.ToUpper().Contains(theme.ToUpper()));

            return await query.ToArrayAsync();
        }
    }
}
