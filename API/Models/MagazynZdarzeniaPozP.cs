using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MagazynZdarzeniaPozP
    {
        public int IdMagazynZdarzeniaPozP { get; set; }
        public int? Lp { get; set; }
        public int? MagazynZdarzeniaPozId { get; set; }
        public int? MagazynZdarzeniaId { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? PaczkiId { get; set; }
        public int? Skan { get; set; }
        public int? Brak { get; set; }
        public double? AnomaliaOpakIlosc { get; set; }
    }
}
