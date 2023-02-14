using MyEvents.API.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyEvents.API.Domain.Entity.Dto;

namespace MyEvents.API.Application.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BatchController : ControllerBase
    {
        private readonly IBatchService _batchService;

        public BatchController (IBatchService batchService)
        {
            _batchService = batchService;
        }

        [HttpGet("id/{idBatch}")]
        public async Task<IActionResult> Get ([FromRoute] uint idBatch)
        {
            var returned = await _batchService.GetBatchById(idBatch);
            return Ok(returned);
        }

        [HttpGet("id/{idEvent}")]
        public async Task<IActionResult> GetAllBatch ([FromRoute] uint idEvent)
        {
            var returned = await _batchService.GetAllBatchByIdEvent(idEvent);
            return Ok(returned);
        }

        [HttpPost]
        public async Task<IActionResult> Post ([FromBody] BatchDto batchDto)
        {
            var returned = await _batchService.InsertBatch(batchDto);
            return Ok(returned);
        }

        [HttpPut("id/{idBatch}")]
        public async Task<IActionResult> Put ([FromRoute] uint idBatch, [FromBody] BatchDto batchDto)
        {
            var returned = await _batchService.UpdateBatch(idBatch, batchDto);
            return Ok(returned);
        }

        [HttpDelete("id/{idBatch}")]
        public async Task<IActionResult> Delete ([FromRoute] uint idBatch)
        {
            var returned = await _batchService.DeleteBatch(idBatch);
            return Ok(returned);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            var returned = await _batchService.DeleteAllBatch();
            return Ok(returned);
        }

    }
}
