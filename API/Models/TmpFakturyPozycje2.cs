using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpFakturyPozycje2
    {
        public int IdTmpFakturyPozycje2 { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public string VatId { get; set; }
        public double? VatStawka { get; set; }
        public int? KursWskRecznie { get; set; }
        public double? KursWaluty { get; set; }
        public int? KursyWalutId { get; set; }
        public double? VKursWaluty { get; set; }
        public int? VKursyWalutId { get; set; }
        public double? NettoWartoscPln { get; set; }
        public double? VatWartoscPln { get; set; }
        public double? BruttoWartoscPln { get; set; }
        public double? WalutowaNettoPln { get; set; }
        public double? WalutowaVatPln { get; set; }
        public double? WalutowaBruttoPln { get; set; }
    }
}
