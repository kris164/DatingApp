using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProfilePermission
    {
        public int ProfilePermissionId { get; set; }
        public int? ProfileId { get; set; }
        public int? PermissionId { get; set; }
        public int? State { get; set; }
    }
}
