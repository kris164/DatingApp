using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpWymPalet2
    {
        public int IdTmpWymPalet2 { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? ZlecenieId { get; set; }
        public string TypZlec { get; set; }
        public int? SystLp { get; set; }
        public string SystTyp { get; set; }
        public string Nazwa { get; set; }
        public int? Lp { get; set; }
        public int? ZaWyId { get; set; }
        public string ZaWy { get; set; }
        public string Typ { get; set; }
        public string Uwagi { get; set; }
        public double? Ilosc1 { get; set; }
        public double? Ilosc2 { get; set; }
        public double? Ilosc3 { get; set; }
        public double? Ilosc4 { get; set; }
        public double? Ilosc5 { get; set; }
        public string Opak1 { get; set; }
        public string Opak2 { get; set; }
        public string Opak3 { get; set; }
        public string Opak4 { get; set; }
        public string Opak5 { get; set; }
        public string KodOpak1 { get; set; }
        public string KodOpak2 { get; set; }
        public string KodOpak3 { get; set; }
        public string KodOpak4 { get; set; }
        public string KodOpak5 { get; set; }
    }
}
