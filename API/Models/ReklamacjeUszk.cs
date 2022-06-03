using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReklamacjeUszk
    {
        public int IdReklamacjeUszk { get; set; }
        public int? ReklamacjeId { get; set; }
        public int? ReklRodzUszkId { get; set; }
        public int? Lp { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public double? Waga { get; set; }
        public string Uwagi { get; set; }
        public int? Waznosc { get; set; }
        public int? Kor { get; set; }
        public DateTime? DataWyk { get; set; }
        public double? Ilosc { get; set; }
    }
}
