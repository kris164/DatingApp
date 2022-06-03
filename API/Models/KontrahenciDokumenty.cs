using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Wymagane dokumenty do zleceń kontrahenta
    /// </summary>
    public partial class KontrahenciDokumenty
    {
        public int IdKontrahenciDokumenty { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Kod dokumentu
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy wymagany
        /// </summary>
        public int? Wymagany { get; set; }
        /// <summary>
        /// Grupa dokumentu
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Status dokumentu
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Flaga, czy ROD
        /// </summary>
        public int? Rod { get; set; }
        /// <summary>
        /// Do kogo zwrot ROD
        /// </summary>
        public string RodDo { get; set; }
        /// <summary>
        /// Flaga, czy eROD
        /// </summary>
        public int? Erod { get; set; }
        /// <summary>
        /// Flaga, czy domyślny
        /// </summary>
        public int? Domyslny { get; set; }
    }
}
