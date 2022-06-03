using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestConfigurationQueryConfiguration
    {
        public int RequestConfigurationQueryConfigurationId { get; set; }
        public int? RequestConfigurationQueryId { get; set; }
        public int? UserId { get; set; }
        public int? Enabled { get; set; }
        public int? PacketSize { get; set; }
        public string QueryHint { get; set; }
    }
}
