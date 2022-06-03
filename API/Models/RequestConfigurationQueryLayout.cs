using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestConfigurationQueryLayout
    {
        public int RequestConfigurationQueryLayoutId { get; set; }
        public int? RequestConfigurationQueryId { get; set; }
        public string Language { get; set; }
        public int? Enabled { get; set; }
        public string Layout { get; set; }
    }
}
