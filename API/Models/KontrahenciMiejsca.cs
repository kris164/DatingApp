using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KontrahenciMiejsca
    {
        public int IdKontrahenciMiejsca { get; set; }
        public string Opis { get; set; }
        public int KontrahId { get; set; }
        public int AdresyId { get; set; }
        public string Rodzaj { get; set; }
        public string Adres { get; set; }
        public string Nr { get; set; }
        public string Kod { get; set; }
        public string Miasto { get; set; }
        public string Gmina { get; set; }
        public string Strefa { get; set; }
        public string SortKod { get; set; }
    }
}
