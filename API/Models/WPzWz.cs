using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WPzWz
    {
        public int IdWPzWz { get; set; }
        public int? WMagPrzyjeciaPozId { get; set; }
        public int? WMagWydaniaPozId { get; set; }
        public int? WMagTowaryId { get; set; }
        public int? Ilosc { get; set; }
        public double? CenaJedn { get; set; }
        public double? Ilosc2 { get; set; }
    }
}
