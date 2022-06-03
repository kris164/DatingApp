using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPolisyPojazdy
    {
        public int IdTmpPolisyPojazdy { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Unikalny identyfikator polisy pojazdy
        /// </summary>
        public int? IdPolisyPojazdy { get; set; }
        public int? PolisyId { get; set; }
        public string Polisy { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public string TaborNrBoczny { get; set; }
        public double? Wartosc { get; set; }
        public double? WartoscPojazdu { get; set; }
        public int? Oc { get; set; }
        public int? Ac { get; set; }
        public int? Nw { get; set; }
        public int? Ass { get; set; }
        public double? Skladka { get; set; }
        public string Subpolisa { get; set; }
    }
}
