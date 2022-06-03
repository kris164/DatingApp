using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WindykacjeZob
    {
        public int IdWindykacjeZob { get; set; }
        public int? WindykacjeId { get; set; }
        public int? Lp { get; set; }
        public DateTime? DataDok { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public string Dokum { get; set; }
        public int? DokumId { get; set; }
        public string TypDok { get; set; }
        public string Opis { get; set; }
        public double? Kwota { get; set; }
        public int? OdsDni { get; set; }
        public int? LiczOdsUstawowe { get; set; }
        public double? OdsUstawowe { get; set; }
        public double? OdsUmowne { get; set; }
        public double? OdsUmowneWart { get; set; }
        public int? OdsUmowneDni { get; set; }
        public int? Splacony { get; set; }
        public DateTime? DataSplaty { get; set; }
        public int? NewNoty { get; set; }
        public DateTime? DtLiczOds { get; set; }
    }
}
