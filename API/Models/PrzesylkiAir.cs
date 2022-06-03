using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozszerzenie tabeli PRZESYLKI - relacja 1:1 z tabelą PRZESYLKI
    /// </summary>
    public partial class PrzesylkiAir
    {
        public int IdPrzesylki { get; set; }
        public string Hawb { get; set; }
        public string Mawb { get; set; }
        public int? AsAgreed { get; set; }
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
        public double? WagaPlatnaUstalona { get; set; }
        public string IncoMiejsce { get; set; }
        public int? AgentHandlId { get; set; }
        public string AgentHandl { get; set; }
        public int? CesjaNaId { get; set; }
        public string CesjaNa { get; set; }
    }
}
