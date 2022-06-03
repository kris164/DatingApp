using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik banków - tabela KIR (Krajowa Izba Rozliczenowa)
    /// </summary>
    public partial class Kir
    {
        /// <summary>
        /// Numer banku (8 cyfr - numer rozliczeniowy banku)
        /// </summary>
        public int Numer { get; set; }
        /// <summary>
        /// Nazwa banku/oddziału
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Adres banku/oddziału
        /// </summary>
        public string Adres { get; set; }
    }
}
