using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosDsm
    {
        public int IdSfmPos { get; set; }
        public short? Satelity { get; set; }
        public string Czujki { get; set; }
        public double? Dystans { get; set; }
        public int? NapiecieGl { get; set; }
        public int? NapiecieRez { get; set; }
        public int? Paliwo1 { get; set; }
        public int? Paliwo1Min { get; set; }
        public int? Paliwo1Max { get; set; }
        public int? Paliwo2 { get; set; }
        public int? Paliwo2Min { get; set; }
        public int? Paliwo2Max { get; set; }
        public short? Wartx { get; set; }
        public short? Inne1 { get; set; }
        public short? Inne2 { get; set; }
        public short? Inne3 { get; set; }
        public short? Inne4 { get; set; }
    }
}
