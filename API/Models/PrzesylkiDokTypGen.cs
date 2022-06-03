using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik typów dla generatora przesyłek dokumentowych
    /// </summary>
    public partial class PrzesylkiDokTypGen
    {
        public int IdPrzesylkiDokTypGen { get; set; }
        /// <summary>
        /// Kod pozycji
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis 
        /// </summary>
        public string Opis { get; set; }
    }
}
