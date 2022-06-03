using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestType
    {
        public int RequestTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
