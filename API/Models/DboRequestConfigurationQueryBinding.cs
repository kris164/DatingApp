using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DboRequestConfigurationQueryBinding
    {
        public int ArchId { get; set; }
        public DateTime ArchDt { get; set; }
        public string ArchOp { get; set; }
        public string ArchSql { get; set; }
        public string ArchHostName { get; set; }
        public int RequestConfigurationQueryBindingId { get; set; }
        public int? RequestConfigurationQueryId { get; set; }
        public string FieldName { get; set; }
        public string Element { get; set; }
    }
}
