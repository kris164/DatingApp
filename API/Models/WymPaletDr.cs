using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WymPaletDr
    {
        public int IdWymPaletDr { get; set; }
        public int? PaczkiId { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? ListyLinioweId { get; set; }
        public string Opakowanie { get; set; }
        public string OpakowanieKod { get; set; }
        public int? IloscOpakZa { get; set; }
        public int? IloscOpakWy { get; set; }
        public int? IloscOpakRozn { get; set; }
        public int? IloscKp { get; set; }
        public string StopienZuzyciaKod { get; set; }
        public double? StopienZuzycia { get; set; }
        public string Uwagi { get; set; }
    }
}
