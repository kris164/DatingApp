using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik pozycji fakturowych - tłumaczenia na inne języki
    /// </summary>
    public partial class PozycjeFakturTlumacz
    {
        public int IdPozycjeFakturTlumacz { get; set; }
        /// <summary>
        /// Relacja do słownika pozycji faktur - tab: POZYCJE_FAKTUR
        /// </summary>
        public int? PozycjeFakturId { get; set; }
        public string JezykPozycji { get; set; }
        /// <summary>
        /// Tytuł pozycji
        /// </summary>
        public string Tytul { get; set; }
        /// <summary>
        /// Szablon do tworzenia opisu na fakturze
        /// </summary>
        public string SzablonDoOpis { get; set; }
    }
}
