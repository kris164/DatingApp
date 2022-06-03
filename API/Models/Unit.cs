using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Unit
    {
        public int UnitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Multiplier { get; set; }
        public int? Weight { get; set; }
        public int? Visible { get; set; }
        public int? Order { get; set; }
    }
}
