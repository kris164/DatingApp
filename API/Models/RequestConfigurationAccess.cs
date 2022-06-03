using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestConfigurationAccess
    {
        public int RequestConfigurationAccessId { get; set; }
        public int? RequestConfigurationId { get; set; }
        public int? RequestProfileId { get; set; }
        public int? UserId { get; set; }
    }
}
