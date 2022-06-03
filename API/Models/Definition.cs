using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Definition
    {
        public int DefinitionId { get; set; }
        public int OlapGroupId { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public int? System { get; set; }
        public int? ToolId { get; set; }
        public int? Www { get; set; }
    }
}
