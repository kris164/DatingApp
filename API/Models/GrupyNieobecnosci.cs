using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik grup nieobecności
    /// </summary>
    public partial class GrupyNieobecnosci
    {
        public int IdGrupyNieobecnosci { get; set; }
        /// <summary>
        /// Kod grupy
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis grupy
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy nieobecność związana z pracą - wyjazd służbowy
        /// </summary>
        public int? CzyPraca { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
