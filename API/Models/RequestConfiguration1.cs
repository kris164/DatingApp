using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestConfiguration1
    {
        public int RequestConfigurationId { get; set; }
        public string Name { get; set; }
        public int? RequestBaseTypeId { get; set; }
        public int? Enabled { get; set; }
        public int? RequestGroupId { get; set; }
        public int? RequestDataTypeId { get; set; }
        public int? MasterConfigurationId { get; set; }
    }
}
