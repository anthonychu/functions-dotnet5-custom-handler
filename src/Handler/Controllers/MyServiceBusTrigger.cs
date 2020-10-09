using Handler.Models;
using Microsoft.AspNetCore.Mvc;

namespace Handler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyServiceBusTrigger : ControllerBase
    {
        [HttpPost]
        public CustomHandlerResponse Post([FromBody]MyServiceBusTriggerRequest request)
        {
            var response = new CustomHandlerResponse();
            response.Logs.Add($"Got message: {request.Data.myQueueItem}");
            return response;
        }
    }
}
