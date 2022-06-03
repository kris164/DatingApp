using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class UserRequestPermission
    {
        public int UserRequestPermissionId { get; set; }
        public int? UserId { get; set; }
        public int? RequestPermissionId { get; set; }
        public int? RequestProfileId { get; set; }
        public int? AllowPermission { get; set; }
        public int? DenyPermission { get; set; }
    }
}
