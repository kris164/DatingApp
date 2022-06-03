using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ToolGroupDefinition
    {
        public int ToolGroupDefinitionId { get; set; }
        public int ToolGroupId { get; set; }
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string ClientToolName { get; set; }
        public int? ToolOrder { get; set; }
        public int? Location { get; set; }
        public int DefaultAction { get; set; }

        public virtual Tool Tool { get; set; }
    }
}
