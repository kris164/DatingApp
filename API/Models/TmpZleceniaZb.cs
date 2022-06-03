using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaZb
    {
        public int IdTmpZleceniaZb { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? SpedytorId { get; set; }
        public DateTime? DataZlecenia { get; set; }
        public DateTime? GodzZlecenia { get; set; }
        public string TypZlecenia { get; set; }
        public int? PrzewoznikId { get; set; }
        public double? TrasaOdl { get; set; }
        public double? TrasaOdlDojazd { get; set; }
        public double? TrasaOdlGl { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
