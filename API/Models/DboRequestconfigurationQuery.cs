using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DboRequestconfigurationQuery
    {
        public int ArchId { get; set; }
        public DateTime ArchDt { get; set; }
        public string ArchOp { get; set; }
        public string ArchSql { get; set; }
        public string ArchHostName { get; set; }
        public int RequestConfigurationQueryId { get; set; }
        public int? RequestConfigurationId { get; set; }
        public string Sql { get; set; }
        public int? Enabled { get; set; }
        public string DataElement { get; set; }
        public string KeyItem { get; set; }
        public string ReferenceKey { get; set; }
        public string KeyGenerator { get; set; }
        public string ReferenceItem { get; set; }
        public int? QueryOrder { get; set; }
        public string TableName { get; set; }
        public int? RequestTypeId { get; set; }
        public int? ExecuteOnly { get; set; }
        public string Layout { get; set; }
        public int? PacketSize { get; set; }
        public string KeyField { get; set; }
        public string ItemField { get; set; }
        public string KeyOrder { get; set; }
        public string ConditionElement { get; set; }
        public string ConditionValue { get; set; }
        public int? RequestData { get; set; }
        public int AllowInsert { get; set; }
        public string QueryHint { get; set; }
        public string ParentElement { get; set; }
    }
}
