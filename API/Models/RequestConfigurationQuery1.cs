using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestConfigurationQuery1
    {
        public int RequestConfigurationQueryId { get; set; }
        public int? RequestConfigurationId { get; set; }
        public string Sql { get; set; }
        public int? Enabled { get; set; }
        public string DataElement { get; set; }
        public int? QueryOrder { get; set; }
        public int? RequestTypeId { get; set; }
        public int? MasterQueryId { get; set; }
    }
}
