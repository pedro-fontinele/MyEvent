using System.Linq;
using System.Threading.Tasks;
using MyEvents.API.Data.Context;
using System.Collections.Generic;
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

        public async void InsertEvents (Event eventModel)
        {
            _dataContext.Event.Add(eventModel);
            await _dataContext.SaveChangesAsync();
        }

        public async void UpdateEvents (Event eventModel)
        {
            _dataContext.Event.Update(eventModel);
            await _dataContext.SaveChangesAsync();
        }

        public async void DeleteEvents (Event eventModel)
        {
            _dataContext.Event.Remove(eventModel);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<Event>> GetAllEvents ()
        {
            IQueryable<Event> query = _dataContext.Event;

            query = query.AsNoTracking()
                         .OrderBy(e => e.IdEvent);

            return await query.ToListAsync();
        }

        public async Task<Event> GetEventsById (uint id)
        {
            IQueryable<Event> query = _dataContext.Event;

            query = query.AsNoTracking()
                         .Where(e => e.IdEvent == id)
                         .OrderBy(e => e.IdEvent);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<Event>> GetEventsByTheme (string theme)
        {
            IQueryable<Event> query = _dataContext.Event;

            query = query.AsNoTracking()
                         .Where(e => e.Theme.ToUpper().Contains(theme.ToUpper()))
                         .OrderBy(e => e.IdEvent);

            return await query.ToListAsync();
        }
    }
}
