using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class NotyPozycje
    {
        public int IdNotyPozycje { get; set; }
        public int NotyId { get; set; }
        public string Opis { get; set; }
        public string NrTabeliKursow { get; set; }
        public int? KursyWalutId { get; set; }
        public double? KursWaluty { get; set; }
        public double? KwotaWal { get; set; }
        public double? Kwota { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public int? OpisId { get; set; }
        public string OpisDod { get; set; }
        public double? Stopa { get; set; }
        public double? KwotaZadluzenia { get; set; }
        public DateTime? DataSplaty { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public int? LiczbaDni { get; set; }
        public int? Lp { get; set; }
    }
}
