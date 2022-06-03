using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Z jakich krajów kontrahent zleca ładunki
    /// </summary>
    public partial class KontrahKrajeZ
    {
        public int IdKontrahKrajeZ { get; set; }
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
