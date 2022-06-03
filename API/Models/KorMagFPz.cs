using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KorMagFPz
    {
        public int? WMagPrzyjeciaPozId { get; set; }
        public int? WMagTowaryId { get; set; }
        public int? FakturyId { get; set; }
        public int? FakturyPozycjeId { get; set; }
        public double? Wydano { get; set; }
        public double? Rezerwacje { get; set; }
    }
}
