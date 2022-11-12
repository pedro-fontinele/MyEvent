using MyEvents.API.Domain.Entity.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.API.Services
{
    public interface IEventService
    {
        Task<Event[]> GetAllEventsAsync();
    }
}
