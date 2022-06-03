using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik statusów
    /// </summary>
    public partial class StatusWind
    {
        public int IdStatusWind { get; set; }
        /// <summary>
        /// Flaga, czy status aktywny
        /// </summary>
        public int Aktywny { get; set; }
        /// <summary>
        /// Flaga, czy status systemowy
        /// </summary>
        public int Systemowy { get; set; }
        /// <summary>
        /// Kod statusu
        /// </summary>
        public int Kod { get; set; }
        /// <summary>
        /// Opis statusu
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Kolor ramki w gridzie
        /// </summary>
        public int? KolorRamki { get; set; }
        /// <summary>
        /// Kolor tekstu w ramce grida
        /// </summary>
        public int? KolorTekstu { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać kolor ramki w gridzie
        /// </summary>
        public int? CzyKolorRamki { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać kolor tekstu w ramce grida
        /// </summary>
        public int? CzyKolorTekstu { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
