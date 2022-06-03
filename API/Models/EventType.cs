using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EventType
    {
        public int EventTypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
