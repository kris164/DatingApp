using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HistoryTable
    {
        public int IdHistoryTables { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string PkColumn { get; set; }
        public int AfterInsert { get; set; }
        public int AfterUpdate { get; set; }
        public int AfterDelete { get; set; }
        public int Enabled { get; set; }
        public string SchemaName { get; set; }
    }
}
