using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik krajów
    /// </summary>
    public partial class Kraje
    {
        public string Symbol { get; set; }
        /// <summary>
        /// Symbol drogowy np. A, D, PL, B etc
        /// </summary>
        public string SymbolDrogowy { get; set; }
        /// <summary>
        /// Waluta danego kraju
        /// </summary>
        public string WalutaKraju { get; set; }
        /// <summary>
        /// Nazwa kraju PL
        /// </summary>
        public string NazwaPol { get; set; }
        /// <summary>
        /// Nazwa kraju EN
        /// </summary>
        public string NazwaEng { get; set; }
        /// <summary>
        /// Nazwa kraju w języku danego kraju
        /// </summary>
        public string NazwaRoot { get; set; }
        /// <summary>
        /// Stawka diety
        /// </summary>
        public double? Dieta { get; set; }
        /// <summary>
        /// Ryczałt na nocleg
        /// </summary>
        public double? NoclegR { get; set; }
        /// <summary>
        /// Waluta dla diety
        /// </summary>
        public string WalutaD { get; set; }
        /// <summary>
        /// Waluta dla noclegu
        /// </summary>
        public string WalutaN { get; set; }
        /// <summary>
        /// Flaga, czy kraj europejski
        /// </summary>
        public int? Eu { get; set; }
        /// <summary>
        /// Flaga, cz kraj jest w unii europejskiej
        /// </summary>
        public int? Ue { get; set; }
        /// <summary>
        /// Grupa krajów
        /// </summary>
        public string GrupaKrajow { get; set; }
        /// <summary>
        /// Dodatek do diety
        /// </summary>
        public double? ZmianaDiet { get; set; }
        /// <summary>
        /// Telefon kierunkowy
        /// </summary>
        public string TelKierunkowy { get; set; }
        /// <summary>
        /// Flaga, czy kraj jest aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Flaga, czy weryfikowac kody pocztowe
        /// </summary>
        public int? WeryfKodow { get; set; }
        /// <summary>
        /// Domyślna stawka VAT dla kraju
        /// </summary>
        public double? DefStVat { get; set; }
        /// <summary>
        /// Flaga, czy kraj dostępny dla systemu WWW
        /// </summary>
        public int? Www { get; set; }
        /// <summary>
        /// Kod kraju wg ISO
        /// </summary>
        public string KodIso { get; set; }
        /// <summary>
        /// Korekta czasu +/- godz
        /// </summary>
        public int? KorGodz { get; set; }
        /// <summary>
        /// Flaga, cz kraj po byłym WNP
        /// </summary>
        public int? Wnp { get; set; }
        /// <summary>
        /// Flaga, czy koszty walutowe
        /// </summary>
        public int? KosztyWalutowe { get; set; }
        /// <summary>
        /// Flaga, czy import usług
        /// </summary>
        public int? ImpUslug { get; set; }
        /// <summary>
        /// Flaga, czy brak NIPu
        /// </summary>
        public int? BrakNip { get; set; }
        /// <summary>
        /// Kod kraju wg ISO 3
        /// </summary>
        public string KodIso3 { get; set; }
        /// <summary>
        /// Flaga, czy pomijac na mapie
        /// </summary>
        public int? PominNaMapie { get; set; }
        public int? IconId { get; set; }
        public int? TrafficLimitHoliday { get; set; }
        public DateTime? TrafficLimitHolidayFrom { get; set; }
        public DateTime? TrafficLimitHolidayTo { get; set; }
        public int? TrafficLimitSun { get; set; }
        public DateTime? TrafficLimitSunFrom { get; set; }
        public DateTime? TrafficLimitSunTo { get; set; }
        public int? TrafficLimitSat { get; set; }
        public DateTime? TrafficLimitSatFrom { get; set; }
        public DateTime? TrafficLimitSatTo { get; set; }
        public int? TrafficLimitFri { get; set; }
        public DateTime? TrafficLimitFriFrom { get; set; }
        public DateTime? TrafficLimitFriTo { get; set; }
        public int? TrafficLimitThu { get; set; }
        public DateTime? TrafficLimitThuFrom { get; set; }
        public DateTime? TrafficLimitThuTo { get; set; }
        public int? TrafficLimitWed { get; set; }
        public DateTime? TrafficLimitWedFrom { get; set; }
        public DateTime? TrafficLimitWedTo { get; set; }
        public int? TrafficLimitTue { get; set; }
        public DateTime? TrafficLimitTueFrom { get; set; }
        public DateTime? TrafficLimitTueTo { get; set; }
        public int? TrafficLimitMon { get; set; }
        public DateTime? TrafficLimitMonFrom { get; set; }
        public DateTime? TrafficLimitMonTo { get; set; }
        /// <summary>
        /// Kod maska
        /// </summary>
        public string KodMaska { get; set; }
        /// <summary>
        /// Symbol do FK
        /// </summary>
        public string SymbolDoFk { get; set; }
        public string VatId { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int IdKraje { get; set; }
        public string PrefixNip { get; set; }
    }
}
