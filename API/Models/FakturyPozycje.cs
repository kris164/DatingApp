using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FakturyPozycje
    {
        public int IdFakturyPozycje { get; set; }
        public int FakturyId { get; set; }
        public int? Lp { get; set; }
        public string RodzKosztow { get; set; }
        public int? UwzglRozlKier { get; set; }
        public int? StrRozlKier { get; set; }
        public string RodzPrzychodow { get; set; }
        public int? TytulId { get; set; }
        public string Tytul { get; set; }
        public string TytulOpis { get; set; }
        public string Pkwiu { get; set; }
        public string Jm { get; set; }
        public double Ilosc { get; set; }
        public double NettoJednWal { get; set; }
        public double NettoJednPln { get; set; }
        public double Rabat { get; set; }
        public double RabatWartoscPln { get; set; }
        public double NettoWartoscPln { get; set; }
        public string VatId { get; set; }
        public double VatStawka { get; set; }
        public double VatWartoscPln { get; set; }
        public double BruttoWartoscPln { get; set; }
        public string Waluta { get; set; }
        public double KursWaluty { get; set; }
        public int? KalkulacjeId { get; set; }
        public int? ZlecPozFaktId { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? TaborLicznik { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? KursyWalutId { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public string KontoFk { get; set; }
        public int? PozKorektaId { get; set; }
        public string TytulTyp { get; set; }
        public double? VKursWaluty { get; set; }
        public int? VKursyWalutId { get; set; }
        public string VNrTabeliKursow { get; set; }
        public DateTime? VDataTabeliKursow { get; set; }
        public DateTime? DataZdarzenia { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string Magazyn { get; set; }
        public int? Zbiorcza { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? ListLiniowyId { get; set; }
        public string ListLiniowy { get; set; }
        public int? SzkodaId { get; set; }
        public string Szkoda { get; set; }
        public int? PromyId { get; set; }
        public string Promy { get; set; }
        public string DotLokalizacji { get; set; }
        public string DotDzialu { get; set; }
        public int? PrzesylkaId { get; set; }
        public string Przesylka { get; set; }
        public string TytulKod { get; set; }
        public int? EfKartyId { get; set; }
        public int? EfKartyTankowaniaId { get; set; }
        public int? ZlecenieMId { get; set; }
        public string ZlecenieM { get; set; }
        public string WZlecenie { get; set; }
        public int? WZlecenieId { get; set; }
        public string WPz { get; set; }
        public int? WPzId { get; set; }
        public string WalutaPrzewal { get; set; }
        public double? KursPrzewal { get; set; }
        public double? NettoJednPrzewal { get; set; }
        public int? TabelaPrzewalId { get; set; }
        public string TabelaPrzewal { get; set; }
        public DateTime? TabelaPrzewalData { get; set; }
        public int? Zrodlo { get; set; }
        public string TytulAgreg { get; set; }
        public int? KursWskRecznie { get; set; }
        public int? KwitPalId { get; set; }
        public string KwitPal { get; set; }
        public int? KwitPalPozId { get; set; }
        public int? WZleceniePozId { get; set; }
        public int? WPzPozId { get; set; }
        public int? KonteneryId { get; set; }
        public string Kontenery { get; set; }
        public double? WalutowaNettoPln { get; set; }
        public double? WalutowaVatPln { get; set; }
        public double? WalutowaBruttoPln { get; set; }
        public int? ZlecenieZbId { get; set; }
        public string ZlecenieZb { get; set; }
        public int? PrefakturyPozId { get; set; }
        public int? KorDoZera { get; set; }
        public int? ZlecenieCId { get; set; }
        public string ZlecenieC { get; set; }
        public double? OrgKwota { get; set; }
        public string OrgWaluta { get; set; }
        public string WWzDlaFk { get; set; }
        public int? ReklamacjeId { get; set; }
        public string Reklamacje { get; set; }
        public string WWz { get; set; }
        public int? WWzId { get; set; }
        public int? WWzPozId { get; set; }
        public string InformacjeDodatkowe { get; set; }
        public int? OpakowanieId { get; set; }
        public string KodOpak { get; set; }
        public int? IloscOpak { get; set; }
        public string WPrzydzialKosztu { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na fakturę sprzedaży z której powstałą bieżąca faktura sprzedaży
        /// </summary>
        public int? MaszonskiMasterFvSId { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na pozycję faktury sprzedaży z której powstałą bieżąca pozycja
        /// </summary>
        public int? MaszonskiMasterFvPozSId { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na fakturę sprzedaży z której powstałą bieżąca faktura kosztowa
        /// </summary>
        public int? MaszonskiMasterFvKId { get; set; }
        /// <summary>
        /// MASZONSKI (dedyk.) - pole wskazuje na pozycję faktury sprzedaży z której powstałą bieżąca pozycja
        /// </summary>
        public int? MaszonskiMasterFvPozKId { get; set; }
        public int? ZlecenieRailId { get; set; }
        public string ZlecenieRail { get; set; }
        public int? ReklKosztyOdszkodId { get; set; }
        public int? IntOrdersPositionsId { get; set; }
        public int? PominNaRap { get; set; }
    }
}
