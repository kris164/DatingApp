using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzekTabor
    {
        public int IdPrzekTabor { get; set; }
        /// <summary>
        /// ID przekierowania
        /// </summary>
        public int IdPrzekierowania { get; set; }
        /// <summary>
        /// ID taboru
        /// </summary>
        public int IdTabor { get; set; }
        /// <summary>
        /// telefon źródłowy
        /// </summary>
        public string Telefon { get; set; }
    }
}
