using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Procesy wykonywane podczas zamykania okresu - detal do OKRESY
    /// </summary>
    public partial class OkresyPoz
    {
        public int IdOkresyPoz { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Relacja do okresu - tab: OKRESY
        /// </summary>
        public int? OkresyId { get; set; }
        /// <summary>
        /// Relacja do procesu - tab: PROCESY_OKR
        /// </summary>
        public int? ProcesyOkrId { get; set; }
        /// <summary>
        /// Symbol procesu okresowego
        /// </summary>
        public string ProcesyOkr { get; set; }
        /// <summary>
        /// Relacja do algorytmu procesu - tab: PROCESY_OKR_ALG
        /// </summary>
        public int? ProcesyOkrAlgId { get; set; }
        /// <summary>
        /// Symbol algorytmu procesu
        /// </summary>
        public string ProcesyOkrAlg { get; set; }
        /// <summary>
        /// Flaga, czy zaznaczono wykonanie
        /// </summary>
        public int? ZaznWykonanie { get; set; }
        /// <summary>
        /// Kto zaznaczył wykonanie
        /// </summary>
        public string ZaznWykonanieKto { get; set; }
        /// <summary>
        /// Flaga, czy proces wykonany
        /// </summary>
        public int? Wykonany { get; set; }
        /// <summary>
        /// Kiedy wykonano proces (data/godz)
        /// </summary>
        public DateTime? WykonanyDataGodz { get; set; }
        /// <summary>
        /// Dodatkowe informacje dotyczące procesu
        /// </summary>
        public string Info { get; set; }
    }
}
