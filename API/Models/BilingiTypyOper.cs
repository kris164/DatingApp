using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Typy operacji w plikach bilingowych GSM
    /// </summary>
    public partial class BilingiTypyOper
    {
        public int IdBilingiTypyOper { get; set; }
        /// <summary>
        /// Relacja do operacji - tab: BILINGI_OPER
        /// </summary>
        public int? BilingiOperId { get; set; }
        /// <summary>
        /// Kod typu operacji
        /// </summary>
        public string KodTypuOperacji { get; set; }
        /// <summary>
        /// Rodzaj kosztów dla operacji
        /// </summary>
        public string RodzKosztow { get; set; }
        /// <summary>
        /// Dodatkowe opcje rodzaju kosztów dla operacji
        /// </summary>
        public string RodzKosztowExt { get; set; }
    }
}
