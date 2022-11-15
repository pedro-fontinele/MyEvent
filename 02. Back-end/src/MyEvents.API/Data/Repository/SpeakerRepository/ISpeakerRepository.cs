using System.Threading.Tasks;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public interface ISpeakerRepository
    {
        void Add<T>(T Entity) where T : class;
        void Update<T>(T Entity) where T : class;
        void Delete<T>(T Entity) where T : class;
        void DeleteRange<T>(T Entity) where T : class;
        Task<bool> SaveChangesAsync();

        Task<Speaker[]> GetAllSpeakerAsync();
        Task<Speaker> GetSpeakerByIdAsync(uint id);
        Task<Speaker[]> GetSpeakerByNameAsync(string name);
    }
}
