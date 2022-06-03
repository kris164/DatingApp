using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestItem
    {
        public int RequestItemId { get; set; }
        public int? RequestConfigurationId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int? Visible { get; set; }
        public int? KeyField { get; set; }
        public int? ItemField { get; set; }
        public int? Width { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public object DefaultValue { get; set; }
        public string Attribute { get; set; }
        public int? RequestItemTypeId { get; set; }
        public int? ParamType { get; set; }
        public int? RequestConfigurationQueryId { get; set; }
    }
}
