using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ListyLinioweLok
    {
        public int IdListyLinioweLok { get; set; }
        public int? ListyLinioweId { get; set; }
        public string Lokalizacja { get; set; }
        public string Etap { get; set; }
        public int? Lp { get; set; }
        public DateTime? DtZa { get; set; }
        public DateTime? DtWy { get; set; }
        public DateTime? DtZaRz { get; set; }
        public DateTime? DtWyRz { get; set; }
        public string StanPlan { get; set; }
        public int? Za { get; set; }
        public int? Wy { get; set; }
        public string NrPlomby { get; set; }
        public int? BlokPlanP { get; set; }
        public int? BlokPlanW { get; set; }
        public int? ZaKoniec { get; set; }
        public int? WyKoniec { get; set; }
        public string NrPlombyWy { get; set; }
        public DateTime? YmGotowoscZa { get; set; }
        public DateTime? YmGotowoscWy { get; set; }
        public string YmBramaZa { get; set; }
        public string YmBramaWy { get; set; }
    }
}
