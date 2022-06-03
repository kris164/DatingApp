using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RodzKosztowRozlMo
    {
        public int IdRodzKosztow { get; set; }
        public int? IleRat { get; set; }
        public int? CzestotliwoscRat { get; set; }
        public int? CzestotliwoscRatKMies { get; set; }
        public int? DekrPw { get; set; }
        public int? DekrPwAlg { get; set; }
        public int? DekrPwWgDaty { get; set; }
        public int? DekrZlec { get; set; }
        public int? DekrZlecAlg { get; set; }
        public int? DekrZlecWgDaty { get; set; }
        public string ProceduraSql { get; set; }
        public int? DekrBezLok { get; set; }
        public int? TworzRm { get; set; }
    }
}
