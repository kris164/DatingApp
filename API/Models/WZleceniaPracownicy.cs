using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WZleceniaPracownicy
    {
        public int IdWZleceniaPracownicy { get; set; }
        public int? WZleceniePozId { get; set; }
        public int? WZlecenieId { get; set; }
        public string WZlecenie { get; set; }
        public int? WPracownicyId { get; set; }
        public string WPracownicy { get; set; }
        public double? ProcentRg { get; set; }
        public double? IloscRg { get; set; }
        public double? Nadg50 { get; set; }
        public double? Nadg100 { get; set; }
        public double? IloscRgDoFv { get; set; }
        public double? IloscRgRz { get; set; }
        public DateTime? DataWykonania { get; set; }
        public int? WZlecenieOfertyPozId { get; set; }
        public int? WZlecenieOfertyId { get; set; }
        public string WZlecenieOferty { get; set; }
    }
}
