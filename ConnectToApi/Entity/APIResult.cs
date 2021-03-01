using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectToApi.Entity
{
    public class APIResult
    {
        public string Message { get; set; }
        public string StatusCode { get; set; }
        public bool Success { get; set; }
        public APIResultObj Result { get; set; }
    }
}