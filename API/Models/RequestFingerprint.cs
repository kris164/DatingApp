using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestFingerprint
    {
        public int RequestFingerprintId { get; set; }
        public string Fingerprint { get; set; }
        public string Name { get; set; }
        public string DetailData { get; set; }
        public int? Active { get; set; }
        public int? MobileApplicationListId { get; set; }
    }
}
