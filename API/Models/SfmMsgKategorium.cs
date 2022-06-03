using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// kategorie komunikatów określające sposób prezentacji komunikatu
    /// </summary>
    public partial class SfmMsgKategorium
    {
        public int IdSfmMsgKategoria { get; set; }
        /// <summary>
        /// Pokaż ilość wiad. u góry ekranu
        /// </summary>
        public short? Aktywna { get; set; }
        /// <summary>
        /// nazwa kategorii
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// opis kategorii
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// ikona max. 32x32
        /// </summary>
        public byte[] Ikona { get; set; }
        /// <summary>
        /// kolor tła
        /// </summary>
        public int? Kolor { get; set; }
        /// <summary>
        /// kolor tekstu i definicja czcionki
        /// </summary>
        public string Font { get; set; }
        /// <summary>
        /// ścieżka do pliku z dźwiękiem
        /// </summary>
        public string Wav { get; set; }
        /// <summary>
        /// Pokaż popup w prawym dolnym rogu ekranu
        /// </summary>
        public short? Popup { get; set; }
    }
}
