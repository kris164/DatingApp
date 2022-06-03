using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborCertyfikaty
    {
        public int IdTaborCertyfikaty { get; set; }
        public int? TaborId { get; set; }
        public string CertyfikatId { get; set; }
        public string Certyfikat { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string NrDokumentu { get; set; }
        public string Uwagi { get; set; }
    }
}
