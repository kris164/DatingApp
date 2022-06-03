using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozszerzenie tabeli PRZESYLKI - relacja 1:1 z tabelą PRZESYLKI
    /// </summary>
    public partial class PrzesylkiSea
    {
        public int IdPrzesylki { get; set; }
        public string Hbl { get; set; }
        public string Mbl { get; set; }
        public int? BuyersConsol { get; set; }
        public int? AsAgreed { get; set; }
        public int? AllIn { get; set; }
        public double? UbezpProcStawka { get; set; }
        public double? UbezpProc { get; set; }
        public double? WagaDekl { get; set; }
        public double? WagaRz { get; set; }
        public double? ObjDekl { get; set; }
        public double? ObjRz { get; set; }
        public double? IloscRz { get; set; }
        public double? WagaDoObl { get; set; }
        public double? WagaObj { get; set; }
        public double? WagaPlatna { get; set; }
        public string IncoMiejsce { get; set; }
        public string UwagiColoader { get; set; }
        public DateTime? DataGotowosci { get; set; }
        public int? Konosament { get; set; }
        public int? UbezpieczycielId { get; set; }
        public string Ubezpieczyciel { get; set; }
    }
}
