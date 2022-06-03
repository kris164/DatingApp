using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Do jakich krajów kontrahent zleca ładunki
    /// </summary>
    public partial class KontrahKrajeDo
    {
        public int IdKontrahKrajeDo { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Symbol kraju
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Nazwa kraju słownie
        /// </summary>
        public string Nazwa { get; set; }
    }
}
