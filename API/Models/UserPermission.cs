using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class UserPermission
    {
        public int UserPermissionId { get; set; }
        public int? ProfileId { get; set; }
        public int? PermissionId { get; set; }
        public int? UserId { get; set; }
        public int? State { get; set; }
    }
}
