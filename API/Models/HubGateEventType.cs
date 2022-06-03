using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HubGateEventType
    {
        public int HubGateEventTypeId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public int TypeId { get; set; }
        public int? IconId { get; set; }
        public int Color { get; set; }
    }
}
