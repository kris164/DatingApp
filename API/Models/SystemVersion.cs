using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SystemVersion
    {
        public int SystemVersionId { get; set; }
        public string VersionName { get; set; }
        public int? Version { get; set; }
        public string Codename { get; set; }
        public int Locked { get; set; }
        public string LockedUser { get; set; }
        public string Information { get; set; }
    }
}
