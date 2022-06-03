using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzelewyDok
    {
        public int IdPrzelewyDok { get; set; }
        public int? PrzelewyId { get; set; }
        public string DokumentTyp { get; set; }
        public int? DokumentId { get; set; }
        public string Dokument { get; set; }
        public double? Kwota { get; set; }
        public double? KwotaSplaty { get; set; }
        public int? SplataId { get; set; }
        public string Nip { get; set; }
        public string InfoDod { get; set; }
        public double? KwotaNetto { get; set; }
        public double? KwotaVat { get; set; }
    }
}
