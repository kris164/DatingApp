using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyWyposazenie
    {
        public int IdKierowcyWyposazenie { get; set; }
        public int KierowcyId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        public DateTime? DataPobrania { get; set; }
        public DateTime? DataZdania { get; set; }
        public string Uwagi { get; set; }
        public double? Wartosc { get; set; }
        public string WartoscWal { get; set; }
        public int? Arch { get; set; }
        public DateTime? DataArch { get; set; }
        public int? WMagWydaniaPozId { get; set; }
    }
}
