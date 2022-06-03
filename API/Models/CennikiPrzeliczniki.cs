using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Przeliczniki do cenników standardowych
    /// </summary>
    public partial class CennikiPrzeliczniki
    {
        public int IdCennikiPrzeliczniki { get; set; }
        /// <summary>
        /// Relacja do cennika - tab: CENNIKI
        /// </summary>
        public int? CennikiId { get; set; }
        /// <summary>
        /// Wartość wejściowa
        /// </summary>
        public int? WartoscZ { get; set; }
        /// <summary>
        /// Jednostka miary wartości wejściowej
        /// </summary>
        public string JmZ { get; set; }
        /// <summary>
        /// Wartość wyjściowa
        /// </summary>
        public int? WartoscDo { get; set; }
        /// <summary>
        /// Jednostka miary wartości wyjściowej
        /// </summary>
        public string JmDo { get; set; }
    }
}
