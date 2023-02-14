using System.Linq;
using System.Threading.Tasks;
using MyEvents.API.Data.Context;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Data.Repository
{
    public class BatchRepository : IBatchRepository
    {
        private readonly DataContext _dataContext;

        public BatchRepository (DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async void InsertBatch (Batch batchModel)
        {
            _dataContext.Batch.Add(batchModel);
            await _dataContext.SaveChangesAsync();
        }

        public async void UpdateBatch (Batch batchModel)
        {
            _dataContext.Batch.Update(batchModel);
            await _dataContext.SaveChangesAsync();
        }

        public async void DeleteBatch (Batch batchModel)
        {
            _dataContext.Batch.Remove(batchModel);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Batch> GetBatchById (uint idBatch)
        {
            IQueryable<Batch> query = _dataContext.Batch;

            query = query.AsNoTracking()
                         .Where(e => e.IdBatch == idBatch);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<Batch>> GetAllBatchByIdEvent (uint idEvent)
        {
            IQueryable<Batch> query = _dataContext.Batch;

            query = query.AsNoTracking()
                         .Where(e => e.IdEvent == idEvent)
                         .OrderBy(e => e.IdBatch);

            return await query.ToListAsync();
        }

        public async Task<List<Batch>> GetAllBatch()
        {
            IQueryable<Batch> query = _dataContext.Batch;

            query = query.AsNoTracking()
                         .OrderBy(e => e.IdBatch);

            return await query.ToListAsync();
        }
    }
}
