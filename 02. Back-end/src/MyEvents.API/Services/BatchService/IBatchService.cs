using System.Threading.Tasks;
using System.Collections.Generic;
using MyEvents.API.Domain.Entity.Dto;

namespace MyEvents.API.Services
{
    public interface IBatchService
    {
        // Actions 
        Task<BatchDto> InsertBatch(BatchDto batchDto);
        Task<BatchDto> UpdateBatch(uint idBatch, BatchDto batchDto);
        Task<BatchDto> DeleteBatch (uint idBatch);
        Task<BatchDto> DeleteAllBatch ();

        // Consult
        Task<BatchDto> GetBatchById (uint idBatch); 
        Task<List<BatchDto>> GetAllBatchByIdEvent (uint idEvent);
    }
}
