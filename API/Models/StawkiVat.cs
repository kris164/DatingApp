using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik stawek VAT
    /// </summary>
    public partial class StawkiVat
    {
        public int IdStawkiVat { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Kod stawki VAT
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Stawka VAT
        /// </summary>
        public double? Stawka { get; set; }
        /// <summary>
        /// Flaga, czy dana stawka jest widoczna w systemie
        /// </summary>
        public short? Widoczny { get; set; }
        /// <summary>
        /// Kody dla drukarki fiskalnej np.: A, B etc
        /// </summary>
        public string KodDrukFisk { get; set; }
        /// <summary>
        /// Wyróżnik dla konta księgowego
        /// </summary>
        public string WyrKonta { get; set; }
    }
}
