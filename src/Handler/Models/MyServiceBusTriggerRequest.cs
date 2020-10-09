namespace Handler.Models
{
    public class MyServiceBusTriggerRequest : CustomHandlerRequest
    {
        public DataModel Data { get; set; }

        public class DataModel
        {
            public string myQueueItem { get; set; }
        }
    }
}