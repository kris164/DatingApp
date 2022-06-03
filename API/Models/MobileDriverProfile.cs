using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileDriverProfile
    {
        public int MobileDriverProfileId { get; set; }
        public int? MobileDriverPermissionId { get; set; }
        public int? MobileDriverProfileTypeId { get; set; }
    }
}
