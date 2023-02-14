using System.Threading.Tasks;
using System.Collections.Generic;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public interface IBatchRepository
    {
        // Actions
        void InsertBatch (Batch batchModel);
        void UpdateBatch (Batch batchModel);
        void DeleteBatch (Batch batchModel);

        // Consult 
        Task<List<Batch>> GetAllBatch ();
        Task<Batch> GetBatchById (uint idBatch);
        Task<List<Batch>> GetAllBatchByIdEvent (uint idEvent);
    }
}
