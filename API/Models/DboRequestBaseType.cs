using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DboRequestBaseType
    {
        public int ArchId { get; set; }
        public DateTime ArchDt { get; set; }
        public string ArchOp { get; set; }
        public string ArchSql { get; set; }
        public string ArchHostName { get; set; }
        public int RequestBaseTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
