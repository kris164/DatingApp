using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzablonyZlecenPozFakt
    {
        public int IdSzablonyZlecenPozFakt { get; set; }
        public int? SzablonyZlecenId { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string Typ { get; set; }
        public int? Lp { get; set; }
        public string RodzPrzychodow { get; set; }
        public string RodzKosztow { get; set; }
        public int? KontrahId { get; set; }
        public string Kontrah { get; set; }
        public int? TytulId { get; set; }
        public string Tytul { get; set; }
        public string TytulOpis { get; set; }
        public string Pkwiu { get; set; }
        public string Jm { get; set; }
        public double? Ilosc { get; set; }
        public double? CenaJedn { get; set; }
        public double? NettoWartosc { get; set; }
        public string VatId { get; set; }
        public double? VatStawka { get; set; }
        public string Waluta { get; set; }
        public string WalutaFv { get; set; }
        public int? FakturyId { get; set; }
        public string Faktury { get; set; }
        public int? PromyId { get; set; }
        public int? Rm { get; set; }
        public int? Ro { get; set; }
        public string TytulKod { get; set; }
        public double? KursWaluty { get; set; }
        public int? KursyWalutId { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public short? KorDoZera { get; set; }
        /// <summary>
        /// FV/NO/RW
        /// </summary>
        public string JakRozl { get; set; }
    }
}
