using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WysylkaJpk
    {
        public int IdWysylkaJpk { get; set; }
        public string Opis { get; set; }
        public int? Cel { get; set; }
        public string Plik { get; set; }
        public string SymbolUs { get; set; }
        public string Lokalizacja { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string Serwer { get; set; }
        public string NumerRef { get; set; }
        public int? KodStatusu { get; set; }
        public int? StatusyJpkId { get; set; }
    }
}
