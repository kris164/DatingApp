using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EAdre
    {
        public int IdEAdres { get; set; }
        public int? KrajId { get; set; }
        public int? MiastoId { get; set; }
        public string Adres { get; set; }
        public string AdresNopl { get; set; }
        public string Kod { get; set; }
        public string KodPoczta { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
        public int? Plac { get; set; }
        public int? Osiedle { get; set; }
        public int? Dzielnica { get; set; }
        public int? Zjazd { get; set; }
        public int? Lotnisko { get; set; }
        public int? Ulica { get; set; }
        public int? Rzeka { get; set; }
        public int? Jezioro { get; set; }
        public int? Cmentarz { get; set; }
        public int? Park { get; set; }
        public int? Most { get; set; }
        public int? Aleja { get; set; }
        public int? Rynek { get; set; }
        public int? Rondo { get; set; }
        public int? Inny { get; set; }
    }
}
