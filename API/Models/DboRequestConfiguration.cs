using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DboRequestConfiguration
    {
        public int ArchId { get; set; }
        public DateTime ArchDt { get; set; }
        public string ArchOp { get; set; }
        public string ArchSql { get; set; }
        public string ArchHostName { get; set; }
        public int RequestConfigurationId { get; set; }
        public string Name { get; set; }
        public int? RequestBaseTypeId { get; set; }
        public int? Enabled { get; set; }
        public int? RequestGroupId { get; set; }
        public int? RequestDataTypeId { get; set; }
        public int? RequestTypeId { get; set; }
    }
}
