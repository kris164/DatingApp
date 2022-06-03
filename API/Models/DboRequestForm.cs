using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DboRequestForm
    {
        public int ArchId { get; set; }
        public DateTime ArchDt { get; set; }
        public string ArchOp { get; set; }
        public string ArchSql { get; set; }
        public string ArchHostName { get; set; }
        public int RequestFormId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? RequestFormBaseTypeId { get; set; }
        public int? ClientId { get; set; }
    }
}
