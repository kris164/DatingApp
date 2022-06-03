using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Błedy z cennika SQL
    /// </summary>
    public partial class CennikiSqlErr
    {
        public int IdCennikiSqlErr { get; set; }
        /// <summary>
        /// Relacja do obiektu którego bład dotyczy
        /// </summary>
        public int ObiektId { get; set; }
        /// <summary>
        /// Typ obiektu [P]rzesyłka, [Z]lecenie FTL, [T]rasa, [PR]om
        /// </summary>
        public string ObiektTyp { get; set; }
        /// <summary>
        /// Relacja do nagłówka definicji - tab: CENNIKI_SQL
        /// </summary>
        public int? CennikiSqlId { get; set; }
        /// <summary>
        /// Kod błedu
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Waga błedu 0-3 - 0 - brak ikonki, 1-3 ikonki zółta, pomarańczowa, czerwona
        /// </summary>
        public int? Waga { get; set; }
    }
}
