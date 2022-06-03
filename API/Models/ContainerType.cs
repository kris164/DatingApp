using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ContainerType
    {
        public int IdContainerType { get; set; }
        public string Kind { get; set; }
        public string Symbol { get; set; }
        public double? Capacity { get; set; }
        public string Unit { get; set; }
    }
}
