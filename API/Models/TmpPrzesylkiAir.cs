using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiAir
    {
        public int IdTmpPrzesylkiAir { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
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
        public string IncoMiejsce { get; set; }
    }
}
