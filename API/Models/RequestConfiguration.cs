using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestConfiguration
    {
        public int RequestConfigurationId { get; set; }
        public string Name { get; set; }
        public int? RequestBaseTypeId { get; set; }
        public int? Enabled { get; set; }
        public int? RequestGroupId { get; set; }
        public int? RequestDataTypeId { get; set; }
        public int? RequestTypeId { get; set; }
    }
}
