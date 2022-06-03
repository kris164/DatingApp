using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPolisySkladki
    {
        public int IdTmpPolisySkladki { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Unikalny identyfikator polisy składki
        /// </summary>
        public int? IdPolisySkladki { get; set; }
        public int? PolisyId { get; set; }
        public string Polisy { get; set; }
        public DateTime? Termin { get; set; }
        public double? Kwota { get; set; }
        public int? Zaplacono { get; set; }
        public DateTime? DataZaplaty { get; set; }
        public double? ProwizjaKwotaPlan { get; set; }
        public double? ProwizjaKwotaRz { get; set; }
        public DateTime? ProwizjaDataPlan { get; set; }
        public DateTime? ProwizjaDataRz { get; set; }
    }
}
