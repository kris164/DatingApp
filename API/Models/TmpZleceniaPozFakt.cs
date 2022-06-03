using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaPozFakt
    {
        public int IdTmpZleceniaPozFakt { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdZleceniaPozFakt { get; set; }
        public string Typ { get; set; }
        public int? Lp { get; set; }
        public int? Rm { get; set; }
        public int? Ro { get; set; }
        public string RodzPrzychodow { get; set; }
        public string RodzKosztow { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public int? KontrahId { get; set; }
        public string Kontrah { get; set; }
        public int? TytulId { get; set; }
        public string Tytul { get; set; }
        public string TytulOpis { get; set; }
        public string TytulKod { get; set; }
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
    }
}
