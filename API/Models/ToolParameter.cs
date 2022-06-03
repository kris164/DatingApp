using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ToolParameter
    {
        public int ToolParameterId { get; set; }
        public int? ToolId { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public object Value { get; set; }
    }
}
