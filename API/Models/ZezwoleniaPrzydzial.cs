using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZezwoleniaPrzydzial
    {
        public int IdZezwoleniaPrzydzial { get; set; }
        public int? ZezwoleniaId { get; set; }
        public int? KierowcaId { get; set; }
        public int? WyjazdId { get; set; }
        public int? TaborId { get; set; }
        public int? StronaOd { get; set; }
        public int? StronaDo { get; set; }
        public DateTime? DtWydania { get; set; }
        public int? WydajacyId { get; set; }
        public DateTime? DtZdania { get; set; }
        public int? PrzyjmujacyId { get; set; }
        public DateTime? DtZwrotu { get; set; }
        public int? ZwracajacyId { get; set; }
    }
}
