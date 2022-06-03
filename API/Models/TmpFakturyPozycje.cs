using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpFakturyPozycje
    {
        public int IdTmpFakturyPozycje { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdFakturyPozycje { get; set; }
        public int? FakturyId { get; set; }
        public int? Zbiorcza { get; set; }
        public int? Lp { get; set; }
        public string TytulTyp { get; set; }
        public int? TytulId { get; set; }
        public string Tytul { get; set; }
        public string TytulOpis { get; set; }
        public string TytulKod { get; set; }
        public string TytulAgreg { get; set; }
        public string Jm { get; set; }
        public double? Ilosc { get; set; }
        public double? NettoJednWal { get; set; }
        public double? NettoJednPln { get; set; }
        public double? Rabat { get; set; }
        public double? RabatWartoscPln { get; set; }
        public double? NettoWartoscPln { get; set; }
        public string VatId { get; set; }
        public double? VatStawka { get; set; }
        public double? VatWartoscPln { get; set; }
        public double? BruttoWartoscPln { get; set; }
        public string Waluta { get; set; }
        public double? KursWaluty { get; set; }
        public int? KursyWalutId { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public double? VKursWaluty { get; set; }
        public int? VKursyWalutId { get; set; }
        public string VNrTabeliKursow { get; set; }
        public DateTime? VDataTabeliKursow { get; set; }
        public int? KalkulacjeId { get; set; }
        public int? PrzesylkaId { get; set; }
        public string Przesylka { get; set; }
        public int? ZlecPozFaktId { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? ZlecenieMId { get; set; }
        public string ZlecenieM { get; set; }
        public int? ListLiniowyId { get; set; }
        public string ListLiniowy { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? KwitPalId { get; set; }
        public string KwitPal { get; set; }
        public int? KwitPalPozId { get; set; }
        public int? PromyId { get; set; }
        public string Promy { get; set; }
        public int? SzkodaId { get; set; }
        public string Szkoda { get; set; }
        public double? OrgKwota { get; set; }
        public string OrgWaluta { get; set; }
        public int? KorDoZera { get; set; }
        public int? ZlecenieRailId { get; set; }
        public string ZlecenieRail { get; set; }
    }
}
