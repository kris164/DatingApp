using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rodzaje przewoźników
    /// </summary>
    public partial class RodzPrzew
    {
        public int IdRodzPrzew { get; set; }
        /// <summary>
        /// Kod rodzaju przewoźnika
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Flaga, czy wymagana umowa
        /// </summary>
        public int? WymUmowa { get; set; }
        /// <summary>
        /// Kolor ramki w gridzie
        /// </summary>
        public int? KolorRamki { get; set; }
        /// <summary>
        /// Kolor tekstu w ramce grida
        /// </summary>
        public int? KolorTekstu { get; set; }
        /// <summary>
        /// Konto księgowe 1
        /// </summary>
        public string KontoFk { get; set; }
    }
}
