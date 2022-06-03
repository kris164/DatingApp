using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik statusów dokumentów
    /// </summary>
    public partial class DokumentyStatus
    {
        public int IdDokumentyStatus { get; set; }
        /// <summary>
        /// Oznaczenie z jakim procesem zwiazane są dokumnety: UBEZPIECZENIA,FTL..
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Flaga, czy status systemowy - dodany przez InterLAN
        /// </summary>
        public int? Systemowy { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
