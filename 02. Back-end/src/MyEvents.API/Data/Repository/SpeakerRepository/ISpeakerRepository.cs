using System.Threading.Tasks;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public interface ISpeakerRepository
    {
        Task<Speaker[]> GetAllSpeakerAsync();
        Task<Speaker> GetSpeakerByIdAsync(uint id);
        Task<Speaker[]> GetSpeakerByNameAsync(string name);
    }
}
