using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiExt
    {
        public int IdTmpPrzesylkiExt { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? PunktyAdrChk { get; set; }
        public double? PunktyAdr { get; set; }
        public double? IloscLqAdr { get; set; }
        public string PrzychodySp { get; set; }
        public string KosztySp { get; set; }
        public int? TempPlus { get; set; }
    }
}
