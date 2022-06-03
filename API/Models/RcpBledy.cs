using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RcpBledy
    {
        public int IdRcpBledy { get; set; }
        public int IdFirma { get; set; }
        public int IdKierowcy { get; set; }
        public int IdOkresRozliczeniowy { get; set; }
        public int IdRcpNag { get; set; }
        public string Opis { get; set; }
    }
}
