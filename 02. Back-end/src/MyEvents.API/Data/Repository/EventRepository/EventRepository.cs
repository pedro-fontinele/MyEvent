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

        public void InsertEvents (Event eventModel)
        {
            _dataContext.Add(eventModel);
            SaveChanges();
        }

        public void UpdateEvents (Event eventModel)
        {
            _dataContext.Update(eventModel);
            SaveChanges();
        }

        public void DeleteEvents (Event eventModel)
        {
            _dataContext.Remove(eventModel);
            SaveChanges();
        }

        public void DeleteAllEvents (Event eventModel)
        {
            _dataContext.Remove(eventModel);
            SaveChanges();
        }

        public void SaveChanges ()
        {
           _dataContext.SaveChanges();
        }

        public async Task<Event[]> GetAllEvents ()
        {
            IQueryable<Event> query = _dataContext.Event.AsNoTracking();

            query = query.OrderBy(e => e.IdEvent);

            return await query.ToArrayAsync();
        }

        public async Task<Event> GetEventsById (uint id)
        {
            IQueryable<Event> query = _dataContext.Event.AsNoTracking();

            query = query.Where(e => e.IdEvent == id)
                         .OrderBy(e => e.IdEvent);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Event[]> GetEventsByTheme (string theme)
        {
            IQueryable<Event> query = _dataContext.Event.AsNoTracking();

            query = query.Where(e => e.Theme.ToUpper().Contains(theme.ToUpper()))
                         .OrderBy(e => e.IdEvent);

            return await query.ToArrayAsync();
        }
    }
}
