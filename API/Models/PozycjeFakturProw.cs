using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Prowizje dla pracowników - detal do tabeli POZYCJE_FAKTUR
    /// </summary>
    public partial class PozycjeFakturProw
    {
        public int IdPozycjeFakturProw { get; set; }
        /// <summary>
        /// Relacja do słownika pozycji faktur - tab: POZYCJE_FAKTUR
        /// </summary>
        public int? PozycjeFakturId { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Symbol użytkownika
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Wartość prowizji
        /// </summary>
        public double? Prowizja { get; set; }
    }
}
