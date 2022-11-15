using System.Linq;
using System.Threading.Tasks;
using MyEvents.API.Data.Context;
using Microsoft.EntityFrameworkCore;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly DataContext _dataContext;

        public EventRepository (DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task InsertEventsAsync (Event eventModel)
        {
            _dataContext.Add(eventModel);
            return Task.CompletedTask;
        }

        public Task UpdateEventsAsync (Event eventModel)
        {
            _dataContext.Update(eventModel);
            return Task.CompletedTask;
        }

        public Task DeleteEventsAsync (Event eventModel)
        {
            _dataContext.Remove(eventModel);
            return Task.CompletedTask;
        }

        public Task DeleteAllEventsAsync (Event eventModel)
        {
            _dataContext.Remove(eventModel);
            return Task.CompletedTask;
        }

        public Task SaveChangesAsync ()
        {
           _dataContext.SaveChangesAsync();
            return Task.CompletedTask;
        }

        public async Task<Event[]> GetAllEventsAsync ()
        {
            IQueryable<Event> query = _dataContext.Event.AsNoTracking();

            query = query.OrderBy(e => e.IdEvent);

            return await query.ToArrayAsync();
        }

        public async Task<Event> GetEventsByIdAsync (uint id)
        {
            IQueryable<Event> query = _dataContext.Event.AsNoTracking();

            query = query.OrderBy(e => e.IdEvent)
                         .Where(e => e.IdEvent == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Event[]> GetEventsByThemeAsync (string theme)
        {
            IQueryable<Event> query = _dataContext.Event.AsNoTracking();

            query = query.OrderBy(e => e.IdEvent)
                         .Where(e => e.Theme.ToUpper().Contains(theme.ToUpper()));

            return await query.ToArrayAsync();
        }
    }
}
