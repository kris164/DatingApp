using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpFaktury
    {
        public int IdTmpFaktury { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdFaktury { get; set; }
        public int? KontrahId { get; set; }
        public string NumerFaktury { get; set; }
        public int? FakturaOtrzymana { get; set; }
        public int? Nota { get; set; }
        public int? NotaUznaniowa { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public DateTime? DataSprzedazy { get; set; }
        public DateTime? DataOtrzymania { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public DateTime? DataWyslania { get; set; }
        public DateTime? DataKsiegowa1 { get; set; }
        public DateTime? DataWyslaniaFk { get; set; }
        public int? RozneKursy { get; set; }
        public string Uwagi { get; set; }
    }
}
