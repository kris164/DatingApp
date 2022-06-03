using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik algorytmów dla procesu okresowego - detal do PROCESY_OKR
    /// </summary>
    public partial class ProcesyOkrAlg
    {
        public int IdProcesyOkrAlg { get; set; }
        /// <summary>
        /// Relacja do procesu - tab: PROCESY_OKR
        /// </summary>
        public int? ProcesyOkrId { get; set; }
        /// <summary>
        /// Flaga, czy algorytm domyślny
        /// </summary>
        public int? Domyslny { get; set; }
        /// <summary>
        /// Nazwa
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Informacje dodatkowe o procesie
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// Parametry algorytmu - struktura ini
        /// </summary>
        public string Parametry { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Flaga, czy algorytm aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Symbol algorytmu
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Dowolne uwagi
        /// </summary>
        public string Uwagi { get; set; }
    }
}
