using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using MyEvents.API.Data.Repository;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Model;

namespace MyEvents.API.Services
{
    public class BatchService : IBatchService
    {
        private readonly IBatchRepository _batchRepository;
        private readonly IMapper _imapper;

        public BatchService(IBatchRepository batchRepository, IMapper imapper)
        {
            _batchRepository = batchRepository;
            _imapper = imapper;
        }

        public async Task<BatchDto> GetBatchById(uint idBatch)
        {
            var returnedBatch = await _batchRepository.GetBatchById(idBatch);
            return _imapper.Map<BatchDto>(returnedBatch);
        }

        public async Task<List<BatchDto>> GetAllBatchByIdEvent(uint idEvent)
        {
            var returnedBatch = await _batchRepository.GetAllBatchByIdEvent(idEvent);
            return _imapper.Map<List<BatchDto>>(returnedBatch);
        }

        public async Task<BatchDto> InsertBatch(BatchDto batchDto)
        {
            if (batchDto != null)
            {
                var batchMap = _imapper.Map<Batch>(batchDto);
                _batchRepository.InsertBatch(batchMap);
                var returnedBatch = await _batchRepository.GetAllBatchByIdEvent(batchDto.IdEvent);
                return _imapper.Map<BatchDto>(returnedBatch);
            }
            return null;
        }

        public async Task<BatchDto> UpdateBatch(uint idBatch, BatchDto batchDto)
        {
            var returnedBatch = await _batchRepository.GetBatchById(idBatch);
            if (returnedBatch != null && batchDto != null)
            {
                var batchMap = _imapper.Map<Batch>(batchDto);
                _batchRepository.UpdateBatch(batchMap);
                return _imapper.Map<BatchDto>(returnedBatch);
            }
            return null;
        }

        public async Task<BatchDto> DeleteBatch(uint idBatch)
        {
            var returnedBatch = await _batchRepository.GetBatchById(idBatch);
            if (returnedBatch != null)
            {
                var batchMap = _imapper.Map<Batch>(returnedBatch);
                _batchRepository.DeleteBatch(batchMap);
            }
            return null;
        }

        public async Task<BatchDto> DeleteAllBatch()
        {
            var returnedBatch = await _batchRepository.GetAllBatch();
            if (returnedBatch != null)
            {
                foreach (var item in returnedBatch)
                {
                    _batchRepository.DeleteBatch(item);
                }
            }
            return null;
        }
    }
}
