using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Handler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyServiceBusTrigger : ControllerBase
    {
        private readonly ILogger<MyServiceBusTrigger> _logger;

        public MyServiceBusTrigger(ILogger<MyServiceBusTrigger> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public CustomHandlerResponse Post([FromBody]MyServiceBusTriggerRequest request)
        {
            var response = new CustomHandlerResponse();
            response.Logs.Add($"Got message: {request.Data.myQueueItem}");
            return response;
        }
    }
}
