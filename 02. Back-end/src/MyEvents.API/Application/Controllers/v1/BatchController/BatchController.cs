using Microsoft.AspNetCore.Mvc;

namespace MyEvents.API.Application.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BatchController : ControllerBase
    {
        public BatchController()
        {
        }
    }
}
