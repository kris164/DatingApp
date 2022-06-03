using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje dostępu do giełd ładunków kontrahenta
    /// </summary>
    public partial class KontrahenciGieldy
    {
        public int IdKontrahenciGieldy { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Flaga, czy zapis aktywny
        /// </summary>
        public int? Aktywna { get; set; }
        /// <summary>
        /// Nazwa giełdy ładunków
        /// </summary>
        public string Gielda { get; set; }
        /// <summary>
        /// Login
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Osoba kontaktowa
        /// </summary>
        public string OsobaKont { get; set; }
        /// <summary>
        /// Dowolne uwagi
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Relacja do pracownika - tab: KONTRAHENCI_REPREZ
        /// </summary>
        public int? ReprezId { get; set; }
    }
}
