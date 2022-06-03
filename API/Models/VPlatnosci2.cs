using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class VPlatnosci2
    {
        public string KeyId { get; set; }
        public short? Typ { get; set; }
        public string Zlecenie { get; set; }
        public string Wyjazd { get; set; }
        public int? Id { get; set; }
        public string Numer { get; set; }
        public string Lokalizacja { get; set; }
        public string Kontrahent { get; set; }
        public int? KontrahentId { get; set; }
        public DateTime? DataWyst { get; set; }
        public DateTime? DataSprzed { get; set; }
        public DateTime? DataPlatn { get; set; }
        public string FormaPl { get; set; }
        public double? Brutto { get; set; }
        public string Waluta { get; set; }
        public double? Splata { get; set; }
        public double? DoZaplaty { get; set; }
        public int? Ile { get; set; }
        public short? BezKsiegowania { get; set; }
        public int? StatusWindykacji { get; set; }
    }
}
