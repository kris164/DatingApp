using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ContainerList
    {
        public int IdContainerList { get; set; }
        public string SerialNumber { get; set; }
        public string Kind { get; set; }
        public string Symbol { get; set; }
        public double? Capacity { get; set; }
        public string Unit { get; set; }
    }
}
