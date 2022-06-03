using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzkodyRozliczenium
    {
        public int IdSzkodyRozliczenia { get; set; }
        public int SzkodyId { get; set; }
        public short Typ { get; set; }
        public DateTime? Data { get; set; }
        public double? Kwota { get; set; }
        public string Opis { get; set; }
        public string Platnik { get; set; }
        public string Wal { get; set; }
        public double? KwotaWal { get; set; }
    }
}
