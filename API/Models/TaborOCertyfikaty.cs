using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborOCertyfikaty
    {
        public int IdTaborOCertyfikaty { get; set; }
        public int? TaborOId { get; set; }
        public string CertyfikatId { get; set; }
        public string Certyfikat { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
    }
}
