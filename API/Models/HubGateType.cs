using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HubGateType
    {
        public int HubGateTypeId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public int? Color { get; set; }
    }
}
