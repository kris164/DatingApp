using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmTrasaP
    {
        public int IdSfmTrasaP { get; set; }
        public int? IdSfmTabor { get; set; }
        public int? IdPw { get; set; }
        public int? IdZlecenia { get; set; }
        public string Nrzlec { get; set; }
        public string Zdarzenie { get; set; }
        public int? IdZawy { get; set; }
        public string Kraj { get; set; }
        public string Kod { get; set; }
        public string Miejscowosc { get; set; }
        public string Adres { get; set; }
        public int? Lp { get; set; }
        public string Pozopis { get; set; }
        public string Pozmiejsc { get; set; }
        public string Pozkod { get; set; }
        public string Pozkraj { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
        public DateTime? Czas { get; set; }
        public DateTime? Czaspobytu { get; set; }
        public DateTime? Dataplanprzyj { get; set; }
        public DateTime? Dataplanwyj { get; set; }
        public int? Potwprzyj { get; set; }
        public DateTime? Dataprzyj { get; set; }
        public int? Potwwyj { get; set; }
        public DateTime? Datawyj { get; set; }
        public int? Status { get; set; }
        public int? IdSfmTrasa { get; set; }
        public string Miejsce { get; set; }
        public double? Odleglosc { get; set; }
    }
}
