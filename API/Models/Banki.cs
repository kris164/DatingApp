using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Banki
    {
        public int IdBanki { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Konto { get; set; }
        public string Bank { get; set; }
        public string KontoKsieg { get; set; }
        public string Waluta { get; set; }
        public string Wyroznik { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
