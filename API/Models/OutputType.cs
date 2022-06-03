using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OutputType
    {
        public int OutputTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Enabled { get; set; }
    }
}
