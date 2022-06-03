using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje sezonów akywności kontrahentów
    /// </summary>
    public partial class Sezony
    {
        public int IdSezony { get; set; }
        /// <summary>
        /// Nazwa sezonu
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Symbol sezonu
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Flaga, czy sezon jest aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Styczeń
        /// </summary>
        public int? Sty { get; set; }
        /// <summary>
        /// Luty
        /// </summary>
        public int? Lut { get; set; }
        /// <summary>
        /// Marzec
        /// </summary>
        public int? Mar { get; set; }
        /// <summary>
        /// Kwiecień
        /// </summary>
        public int? Kwi { get; set; }
        /// <summary>
        /// Maj
        /// </summary>
        public int? Maj { get; set; }
        /// <summary>
        /// Czerwiec
        /// </summary>
        public int? Cze { get; set; }
        /// <summary>
        /// Lipiec
        /// </summary>
        public int? Lip { get; set; }
        /// <summary>
        /// Sierpień
        /// </summary>
        public int? Sie { get; set; }
        /// <summary>
        /// Wrzesień
        /// </summary>
        public int? Wrz { get; set; }
        /// <summary>
        /// Październik
        /// </summary>
        public int? Paz { get; set; }
        /// <summary>
        /// Listopad
        /// </summary>
        public int? Lis { get; set; }
        /// <summary>
        /// Grudzień
        /// </summary>
        public int? Gru { get; set; }
    }
}
