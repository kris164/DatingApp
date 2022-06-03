using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Nagłówek pliku z transakcjami kart paliwowych
    /// </summary>
    public partial class KartyPliki
    {
        public int IdKartyPliki { get; set; }
        /// <summary>
        /// Data wczytania pliku z bilingiem
        /// </summary>
        public DateTime? DataWczytania { get; set; }
        /// <summary>
        /// Godzina wczytania pliku z bilingiem
        /// </summary>
        public DateTime? CzasWczytania { get; set; }
        /// <summary>
        /// Nazwa wczytanego pliku
        /// </summary>
        public string NazwaPliku { get; set; }
        /// <summary>
        /// Kto wczytał
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Ilość operacji w pliku
        /// </summary>
        public int? IloscOperacji { get; set; }
        /// <summary>
        /// Typ pliku
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Dowolne uwagi do pliku
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Relacja do faktury kosztowej - tab: FAKTURY
        /// </summary>
        public int? FFakturaId { get; set; }
        /// <summary>
        /// Numer faktury kosztowej
        /// </summary>
        public string FFaktura { get; set; }
        /// <summary>
        /// Relacja do kontrahenta z faktury - tab: KONTRAHENCI
        /// </summary>
        public int? FKontrahId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string FKontrah { get; set; }
        /// <summary>
        /// Data z faktury kosztowej
        /// </summary>
        public DateTime? FData { get; set; }
        /// <summary>
        /// Waluta z faktury kosztowej
        /// </summary>
        public string FWaluta { get; set; }
        /// <summary>
        /// Kwota netto z faktury kosztowej
        /// </summary>
        public double? FNetto { get; set; }
        /// <summary>
        /// Kwota VAT z faktury kosztowej
        /// </summary>
        public double? FVat { get; set; }
        /// <summary>
        /// Kwota brutto z faktury kosztowej
        /// </summary>
        public double? FBrutto { get; set; }
        /// <summary>
        /// Kwota netto w PLN z faktury kosztowej
        /// </summary>
        public double? FNettoPln { get; set; }
        /// <summary>
        /// Kwota VAT w PLN z faktury kosztowej
        /// </summary>
        public double? FVatPln { get; set; }
        /// <summary>
        /// Kwota brutto w PLN z faktury kosztowej
        /// </summary>
        public double? FBruttoPln { get; set; }
        /// <summary>
        /// Łączna ilość w pliku
        /// </summary>
        public double? SumaIlosci { get; set; }
        /// <summary>
        /// Łączna wartość netto w pliku
        /// </summary>
        public double? SumaPozNetto { get; set; }
        /// <summary>
        /// Łączna wartość VAT w pliku
        /// </summary>
        public double? SumaPozVat { get; set; }
        /// <summary>
        /// Łączna wartość brutto w pliku
        /// </summary>
        public double? SumaPozBrutto { get; set; }
        /// <summary>
        /// Flaga, czy suma z FV = suma z transakcji
        /// </summary>
        public int? FvTr { get; set; }
        /// <summary>
        /// Stan pliku: 0 - otwarty, 1 - zamkniety
        /// </summary>
        public short? Stan { get; set; }
        /// <summary>
        /// Rabat z faktury - netto w PLN
        /// </summary>
        public double? FRabatNettoPln { get; set; }
        /// <summary>
        /// Lokalizacja wczytania pliku
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Relacja do WZ  z warsztatu
        /// </summary>
        public int? WMagWydaniaId { get; set; }
    }
}
