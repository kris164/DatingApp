using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PaczkiSkan
    {
        public int IdPaczkiSkan { get; set; }
        public int? PaczkiId { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? MagazynZdarzeniaId { get; set; }
        public int? Skan { get; set; }
        public int? Brak { get; set; }
        public DateTime? SkanDt { get; set; }
    }
}
