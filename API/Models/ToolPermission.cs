using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ToolPermission
    {
        public int ToolPermissionId { get; set; }
        public int? ProfileId { get; set; }
        public int? ToolId { get; set; }
        public int? State { get; set; }
    }
}
