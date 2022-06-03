using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik procesów okresowych
    /// </summary>
    public partial class ProcesyOkr
    {
        public int IdProcesyOkr { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Flaga, czy proces aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Nazwa
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Informacje dodatkowe o procesie
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Dowolne uwagi
        /// </summary>
        public string Uwagi { get; set; }
    }
}
