using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpAwizacjePoz
    {
        public int IdTmpAwizacjePoz { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? AwizacjeId { get; set; }
        public int? Lp { get; set; }
        public int? PrzesylkiId { get; set; }
        public double? Waga { get; set; }
        public double? Obj { get; set; }
        public double? Ilosc { get; set; }
        public double? MiejscaPal { get; set; }
        public double? IloscPal { get; set; }
        public double? IloscPac { get; set; }
    }
}
