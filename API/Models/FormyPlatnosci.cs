using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik form płatności
    /// </summary>
    public partial class FormyPlatnosci
    {
        public int IdFormyPlatnosci { get; set; }
        /// <summary>
        /// Kod formy płatności
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Flaga, czy płatność kartą
        /// </summary>
        public int? Karta { get; set; }
        /// <summary>
        /// Flaga, czy nanosić automatycznie zapłatę
        /// </summary>
        public int? AutoZaplata { get; set; }
        /// <summary>
        /// Flaga, czy płatność przelewem
        /// </summary>
        public int? Przelew { get; set; }
        /// <summary>
        /// Flaga, czy COD
        /// </summary>
        public int? Cod { get; set; }
        public string KontoFk { get; set; }
        /// <summary>
        /// Flaga, czy rozlicza zaliczkę
        /// </summary>
        public int? RozlZaliczke { get; set; }
    }
}
