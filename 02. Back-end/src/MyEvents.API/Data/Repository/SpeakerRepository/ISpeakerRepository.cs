using System.Threading.Tasks;
using System.Collections.Generic;
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

        Task<List<Speaker>> GetAllSpeakerAsync();
        Task<Speaker> GetSpeakerByIdAsync(uint id);
        Task<List<Speaker>> GetSpeakerByNameAsync(string name);
    }
}
