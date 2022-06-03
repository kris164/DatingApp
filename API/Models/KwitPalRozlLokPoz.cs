using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje rozliczenia palet w lokalizacjach
    /// </summary>
    public partial class KwitPalRozlLokPoz
    {
        public int IdKwitPalRozlLokPoz { get; set; }
        /// <summary>
        /// Relacja do KWIT_PAL_ROZL_LOK
        /// </summary>
        public int? KwitPalRozlLokId { get; set; }
        /// <summary>
        /// Relacja do KWIT_PAL_ROZL
        /// </summary>
        public int? KwitPalRozlId { get; set; }
        /// <summary>
        /// Relacja do KWIT_PAL_ROZL_POZ
        /// </summary>
        public int? KwitPalRozlPozId { get; set; }
        /// <summary>
        /// Relacja do przesyłki
        /// </summary>
        public int? PrzesylkiId { get; set; }
        /// <summary>
        /// Nr przesyłki
        /// </summary>
        public string Przesylki { get; set; }
        /// <summary>
        /// Lokalizacja nadzorująca z przesyłki
        /// </summary>
        public string LokalizacjaNadz { get; set; }
        /// <summary>
        /// Relacja do paczki
        /// </summary>
        public int? PaczkiId { get; set; }
        /// <summary>
        /// Nr paczki
        /// </summary>
        public string Paczki { get; set; }
        /// <summary>
        /// Kod opakowania
        /// </summary>
        public string KodOpak { get; set; }
        /// <summary>
        /// Opakowanie
        /// </summary>
        public string Opakowanie { get; set; }
        /// <summary>
        /// Ilość opakowań
        /// </summary>
        public int? Ilosc { get; set; }
    }
}
