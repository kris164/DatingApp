using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Prawa cennika SQL
    /// </summary>
    public partial class CennikiSqlPrawa
    {
        public int IdCennikiSqlPrawa { get; set; }
        /// <summary>
        /// Relacja do nagłówka definicji - tab: CENNIKI_SQL
        /// </summary>
        public int? CennikId { get; set; }
        /// <summary>
        /// Nazwa lokalizacji
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Nazwa dzialu
        /// </summary>
        public string Dzial { get; set; }
    }
}
