using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Tabelka VAT dla faktury
    /// </summary>
    public partial class FakturyVat
    {
        public int IdFakturyVat { get; set; }
        public int FakturyId { get; set; }
        public int SpLiczenia { get; set; }
        public string VatId { get; set; }
        public double VatStawka { get; set; }
        public double Netto { get; set; }
        public double Vat { get; set; }
        public double Brutto { get; set; }
        public double NettoPln { get; set; }
        public double VatPln { get; set; }
        public double BruttoPln { get; set; }
        public int Zmien { get; set; }
        public int ZmienPln { get; set; }
    }
}
