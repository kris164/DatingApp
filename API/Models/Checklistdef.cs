using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik pozycji list kontrolnych
    /// </summary>
    public partial class Checklistdef
    {
        public int IdChecklistdef { get; set; }
        /// <summary>
        /// Jakiego obiektu dotyczy pozycja
        /// </summary>
        public int? Objid { get; set; }
        /// <summary>
        /// Kod pozycji
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Opis 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Flaga, czy pozycja aktywna
        /// </summary>
        public int? Inuse { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
