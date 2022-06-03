using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaInstrDod
    {
        public int IdTmpZleceniaInstrDod { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public string Kod { get; set; }
        public string Uwagi { get; set; }
        public DateTime? Data { get; set; }
        public double? Kwota { get; set; }
        public string KwotaWal { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? Cod { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? Cennik { get; set; }
        /// <summary>
        /// Redundantnie na podstwie słownika INSTRUKCJE_DOD
        /// </summary>
        public int? Opcjonalna { get; set; }
    }
}
