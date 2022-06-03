using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Kasy
    {
        public int IdKasy { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? KasjerId { get; set; }
        public string Kasjer { get; set; }
        public string Waluta { get; set; }
        public string KontoKsieg { get; set; }
        public string KontoZasilen { get; set; }
        public string KontoOdprowadzen { get; set; }
        public string Wyroznik { get; set; }
        public int? LicznikRk { get; set; }
        public int? LicznikOperKp { get; set; }
        public int? LicznikOperKw { get; set; }
        public int? PominSpecPrzyZ { get; set; }
        public string EmailInfo { get; set; }
        public int? BlokadaZerowegoSalda { get; set; }
        public int? IleMaxRkDziennie { get; set; }
    }
}
