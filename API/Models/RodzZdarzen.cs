using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik zdarzeń transportowych
    /// </summary>
    public partial class RodzZdarzen
    {
        public int IdRodzZdarzen { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Kod
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy zdarzenie systemowe
        /// </summary>
        public int? Systemowy { get; set; }
        /// <summary>
        /// Kolor ramki w gridzie
        /// </summary>
        public int? KolorRamki { get; set; }
        /// <summary>
        /// Kolor tekstu w ramce grida
        /// </summary>
        public int? KolorTekstu { get; set; }
        /// <summary>
        /// Flaga, czy bez weryfikacji na PW
        /// </summary>
        public int? BezWeryfPw { get; set; }
        /// <summary>
        /// Flaga, czy uwzględniać rodzaj w budowaniu trasy
        /// </summary>
        public int? UwzglDoTrasy { get; set; }
        /// <summary>
        /// Flaga, czy aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać kolor ramki w gridzie
        /// </summary>
        public int? CzyKolorRamki { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać kolor tekstu w ramce grida
        /// </summary>
        public int? CzyKolorTekstu { get; set; }
        /// <summary>
        /// Flaga, czy nie przekazywać do mapy
        /// </summary>
        public int? BezMapy { get; set; }
        /// <summary>
        /// Flaga, czy pokazywać w dyspozytorze
        /// </summary>
        public int? PokazWDysp { get; set; }
        /// <summary>
        /// Flaga, czy pokazywać w mSPEED
        /// </summary>
        public int? MobileActive { get; set; }
        /// <summary>
        /// Nr ikony w mSPEED
        /// </summary>
        public int? MobileIconId { get; set; }
        /// <summary>
        /// Nr ikony w mSPEED
        /// </summary>
        public int? BezKopiowania { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
