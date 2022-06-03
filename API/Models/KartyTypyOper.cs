using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Typy operacji w plikach od dostawców
    /// </summary>
    public partial class KartyTypyOper
    {
        public int IdKartyTypyOper { get; set; }
        /// <summary>
        /// Relacja do wydawcy karty - tab: KARTY_WYDAWCY
        /// </summary>
        public int? KartyWydawcyId { get; set; }
        /// <summary>
        /// Kod operacji dostawcy
        /// </summary>
        public string KodTypuOperacji { get; set; }
        /// <summary>
        /// Rodzaj kosztów
        /// </summary>
        public string RodzKosztow { get; set; }
        /// <summary>
        /// Dodatkowe opcje rodzaju kosztów
        /// </summary>
        public string RodzKosztowExt { get; set; }
    }
}
