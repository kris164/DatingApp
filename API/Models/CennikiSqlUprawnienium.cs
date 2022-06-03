using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Uprawnienia do statusów
    /// </summary>
    public partial class CennikiSqlUprawnienium
    {
        public int IdCennikiSqlUprawnienia { get; set; }
        /// <summary>
        /// Relacja do nagłówka definicji - tab: CENNIKI_SQL
        /// </summary>
        public int CennikId { get; set; }
        /// <summary>
        /// Typ uprawnienia 0 - user, 1 - profil
        /// </summary>
        public int Typ { get; set; }
        /// <summary>
        /// Relacja do użytkownika, profilu
        /// </summary>
        public int ObiektId { get; set; }
        public int Edycja { get; set; }
        public int Widok { get; set; }
    }
}
