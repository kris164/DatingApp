using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik typów dokumentów dla książki pocztowej
    /// </summary>
    public partial class KsPocztDokum
    {
        public int IdKsPocztDokum { get; set; }
        /// <summary>
        /// Typ obiektu - FV, ZL etc
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Opis typu obiektu
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy dotyczy poczty wychodzacej
        /// </summary>
        public int? Nad { get; set; }
        /// <summary>
        /// Flaga, czy dotyczy poczty przychodzącej
        /// </summary>
        public int? Odb { get; set; }
        /// <summary>
        /// Numer segregatora poczty wychodzącej
        /// </summary>
        public string SegregatorNad { get; set; }
        /// <summary>
        /// Numer segregatora poczty przychodzacej
        /// </summary>
        public string SegregatorOdb { get; set; }
        /// <summary>
        /// Flaga, czy aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Flaga, czy systemowy - zdefiniowany przez InterLAN
        /// </summary>
        public int? Systemowy { get; set; }
        /// <summary>
        /// Flaga, czy drukowac kod kreskowy
        /// </summary>
        public int? DrukujKod { get; set; }
        /// <summary>
        /// Flaga, czy kontrolowac adresy
        /// </summary>
        public int? KontrolaAdresow { get; set; }
        /// <summary>
        /// Flaga, czy można dopisywać obiekty w trybie &quot;Dopisz wiele&quot;
        /// </summary>
        public int? DopiszWiele { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
