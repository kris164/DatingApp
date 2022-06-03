using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Uprawnienia do statusów
    /// </summary>
    public partial class StatusUprawnienium
    {
        public int IdStatusUprawnienia { get; set; }
        /// <summary>
        /// Relacja do statusu, tab: STATUS
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// Typ uprawnienia 0 - user, 1 - profil
        /// </summary>
        public int Typ { get; set; }
        /// <summary>
        /// Relacja do użytkownika, profilu
        /// </summary>
        public int ObiektId { get; set; }
    }
}
