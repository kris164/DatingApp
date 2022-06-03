using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DokumentyKierowcy
    {
        public int IdDokumentyKierowcy { get; set; }
        public string DokumentId { get; set; }
        public string Dokument { get; set; }
        public int? PracownikId { get; set; }
        public DateTime? DataDo { get; set; }
        public string InfoDod { get; set; }
        public int? Visible { get; set; }
        public int? BlokujPo { get; set; }
        public int? Arch { get; set; }
        public DateTime? DataArch { get; set; }
        public string Uwagi { get; set; }
    }
}
