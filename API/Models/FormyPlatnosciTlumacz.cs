using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik form płatności - tłumaczenia na inne języki
    /// </summary>
    public partial class FormyPlatnosciTlumacz
    {
        public int IdFormyPlatnosciTlumacz { get; set; }
        /// <summary>
        /// Relacja do słownika form płatności - tab: FORMY_PLATNOSCI
        /// </summary>
        public int FormyPlatnosciId { get; set; }
        /// <summary>
        /// Kod języka
        /// </summary>
        public string JezykPozycji { get; set; }
        /// <summary>
        /// Kod formy płatności
        /// </summary>
        public string Kod { get; set; }
    }
}
