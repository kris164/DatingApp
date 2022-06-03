using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestFormPermission
    {
        public int RequestFormPermissionId { get; set; }
        public int? RequestFormItemId { get; set; }
        public int? UserId { get; set; }
        public int? RequestProfileId { get; set; }
        public int? AllowPermission { get; set; }
        public int? DenyPermission { get; set; }
    }
}
