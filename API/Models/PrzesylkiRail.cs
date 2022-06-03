using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozszerzenie tabeli PRZESYLKI - relacja 1:1 z tabelą PRZESYLKI
    /// </summary>
    public partial class PrzesylkiRail
    {
        public int IdPrzesylki { get; set; }
        public int? AllIn { get; set; }
        public double? UbezpProcStawka { get; set; }
        public double? UbezpProc { get; set; }
        public int? UbezpieczycielId { get; set; }
        public string Ubezpieczyciel { get; set; }
        public double? WagaDekl { get; set; }
        public double? WagaRz { get; set; }
        public double? ObjDekl { get; set; }
        public double? ObjRz { get; set; }
        public double? IloscRz { get; set; }
        public double? WagaDoObl { get; set; }
        public double? WagaObj { get; set; }
        public double? WagaPlatna { get; set; }
        public int? WeightConversionId { get; set; }
        public string IncoMiejsce { get; set; }
    }
}
