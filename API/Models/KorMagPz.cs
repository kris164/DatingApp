using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KorMagPz
    {
        public int IdKorMagPz { get; set; }
        public DateTime? Data { get; set; }
        public int? WMagPrzyjeciaId { get; set; }
        public int? WMagPrzyjeciaPozId { get; set; }
        public int? WMagTowaryId { get; set; }
        public double? IloscP { get; set; }
        public double? Ilosc { get; set; }
        public double? Przelicznik { get; set; }
        public double? KorektaIloscP { get; set; }
        public double? KorektaIlosc { get; set; }
        public double? Wydano { get; set; }
        public double? Rezerwacje { get; set; }
    }
}
