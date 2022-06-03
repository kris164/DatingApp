using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CrmCelUprawnienium
    {
        public int IdCrmCelUprawnienia { get; set; }
        /// <summary>
        /// Relacja do celu, tab: CRM_CEL
        /// </summary>
        public int CrmCelId { get; set; }
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
