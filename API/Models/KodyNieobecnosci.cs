using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik kodów nieobecności
    /// </summary>
    public partial class KodyNieobecnosci
    {
        public int IdKodyNieobecnosci { get; set; }
        /// <summary>
        /// Kod nieobecności
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis nieobecności
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy nieobecność związana z pracą - wyjazd służbowy
        /// </summary>
        public int? CzyPraca { get; set; }
        /// <summary>
        /// Flaga, czy kod standardowy
        /// </summary>
        public int? Standard { get; set; }
        /// <summary>
        /// Grupa nieobecności - tab: GRUPY_NIEOBECNOSCI
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Kolor na planerze urlopów
        /// </summary>
        public int? Kolor { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
