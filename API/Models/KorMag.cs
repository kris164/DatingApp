using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KorMag
    {
        public int IdKorMag { get; set; }
        public DateTime? Data { get; set; }
        public int? WMagPrzyjeciaId { get; set; }
        public int? WMagPrzyjeciaPozId { get; set; }
        public int? WMagWydaniaId { get; set; }
        public int? WMagWydaniaPozId { get; set; }
        public int? WZleceniaId { get; set; }
        public int? WZleceniaPozId { get; set; }
        public int? FakturyId { get; set; }
        public int? FakturyPozycjeId { get; set; }
        public int? PzZamkniete { get; set; }
        public int? WzZamkniete { get; set; }
        public int? WMagTowaryId { get; set; }
        public double? Ilosc { get; set; }
    }
}
