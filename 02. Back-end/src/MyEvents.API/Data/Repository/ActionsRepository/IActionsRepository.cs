using System.Threading.Tasks;

namespace MyEvents.API.Data.Repository
{
    public interface IActionsRepository
    {
        void Add<T>(T Entity) where T : class;
        void Update<T>(T Entity) where T : class;
        void Delete<T>(T Entity) where T : class;
        void DeleteRange<T>(T Entity) where T : class;
        Task<bool> SaveChangesAsync();
    }
}
