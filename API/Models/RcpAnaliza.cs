using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RcpAnaliza
    {
        public int IdRcpAnaliza { get; set; }
        public int IdFirma { get; set; }
        public int IdKierowcy { get; set; }
        public int IdOkresRozliczeniowy { get; set; }
        public int IdRcpNag { get; set; }
        public int? Tryb { get; set; }
        public int? Tryb2 { get; set; }
        public DateTime? DataczasOd { get; set; }
        public DateTime? DataczasDo { get; set; }
        public int? Tryb3 { get; set; }
        public string Tabor { get; set; }
        public int? MTrwanie { get; set; }
    }
}
