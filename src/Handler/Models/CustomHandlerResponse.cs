using System;
using System.Collections.Generic;

namespace Handler.Models
{
    public class CustomHandlerResponse
    {
        public IDictionary<string, object> Outputs { get; set; }  = new Dictionary<string, object>();
        public IList<string> Logs { get; set; } = new List<string>();
        public object ReturnValue { get; set; } = new object {};
    }
}
