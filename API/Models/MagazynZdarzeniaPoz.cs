using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MagazynZdarzeniaPoz
    {
        public int IdMagazynZdarzeniaPoz { get; set; }
        public int? MagazynZdarzeniaId { get; set; }
        public string ObiektTyp { get; set; }
        public int? ObiektId { get; set; }
        public int? Lp { get; set; }
        public int? Skan { get; set; }
        public string Lokacja { get; set; }
        public DateTime? SkanDt { get; set; }
        public int? ZatwPoSkan { get; set; }
        public int? ListyLiniowePozId { get; set; }
        public int? Brak { get; set; }
    }
}
