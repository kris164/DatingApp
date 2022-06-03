using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpListyLinioweLok
    {
        public int IdTmpListyLinioweLok { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public string Lokalizacja { get; set; }
        public string Etap { get; set; }
        public int? Lp { get; set; }
        public int? Za { get; set; }
        public int? Wy { get; set; }
        public DateTime? DtZa { get; set; }
        public DateTime? DtWy { get; set; }
        public DateTime? DtZaRz { get; set; }
        public DateTime? DtWyRz { get; set; }
        public string StanPlan { get; set; }
        public string NrPlomby { get; set; }
        public int? BlokPlanP { get; set; }
        public int? BlokPlanW { get; set; }
        public int? ZaKoniec { get; set; }
        public int? WyKoniec { get; set; }
    }
}
