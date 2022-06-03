using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Module
    {
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Range1 { get; set; }
        public int? Range2 { get; set; }
        public string Plugin { get; set; }
        public int? Version { get; set; }
        public int? Index { get; set; }
    }
}
