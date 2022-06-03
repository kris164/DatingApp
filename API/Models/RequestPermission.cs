using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestPermission
    {
        public int RequestPermissionId { get; set; }
        public string Name { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? RequestPermissionGroupId { get; set; }
        public int? Active { get; set; }
        public int? PermissionLevel { get; set; }
    }
}
