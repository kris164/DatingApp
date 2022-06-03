using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Permission
    {
        public int PermissionId { get; set; }
        public int? PermissionGroupId { get; set; }
        public string Name { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? Visible { get; set; }
    }
}
