using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Mapowanie kodu kreskowego do identyfikatora systemowego
    /// </summary>
    public partial class KodyKreskoweDok
    {
        public int IdKodyKreskoweDok { get; set; }
        /// <summary>
        /// Typ obiektu wg tabeli KS_POCZT_DOKUM + #KOP# (koperta)
        /// </summary>
        public string ObiektTyp { get; set; }
        /// <summary>
        /// Identyfikator obiektu systemowego
        /// </summary>
        public int? ObiektId { get; set; }
    }
}
