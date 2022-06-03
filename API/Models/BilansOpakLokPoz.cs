using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class BilansOpakLokPoz
    {
        public int IdBilansOpakLokPoz { get; set; }
        public int BilansOpakLokId { get; set; }
        public string LokalizacjaZ { get; set; }
        public string LokalizacjaDo { get; set; }
        public string KodOpak { get; set; }
        public int Ilosc { get; set; }
        public int IloscZPrzeniesienia { get; set; }
        public int IloscSkorygowana { get; set; }
        public int? IloscRozliczona { get; set; }
        public int? IloscNaPp { get; set; }
        public int? IloscDoRozliczenia { get; set; }
        public int? Zrodlo { get; set; }
        public string PrzyczynaKor { get; set; }
        public string OpisDod { get; set; }
    }
}
