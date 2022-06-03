using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DboRequestProfilePermission
    {
        public int ArchId { get; set; }
        public DateTime ArchDt { get; set; }
        public string ArchOp { get; set; }
        public string ArchSql { get; set; }
        public string ArchHostName { get; set; }
        public int RequestProfilePermissionId { get; set; }
        public int? RequestProfileId { get; set; }
        public int? RequestPermissionId { get; set; }
        public int? AllowPermission { get; set; }
        public int? DenyPermission { get; set; }
    }
}
