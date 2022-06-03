using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKalkStawkiLtl
    {
        public int IdTmpKalkStawkiLtl { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public string Grupa { get; set; }
        public int? Lp { get; set; }
        public int? KlientId { get; set; }
        public int? OpisId { get; set; }
        public string OpisDod { get; set; }
        public double? Ilosc { get; set; }
        public string Jm { get; set; }
        public double? CenaJedn { get; set; }
        public double? Netto { get; set; }
        public string Waluta { get; set; }
        public string Info { get; set; }
        public string CennikInfo { get; set; }
        public int? PaczkiId { get; set; }
    }
}
