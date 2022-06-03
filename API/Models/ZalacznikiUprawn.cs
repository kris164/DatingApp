using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Załączniki systemowe - uprawnienia
    /// </summary>
    public partial class ZalacznikiUprawn
    {
        public int IdZalacznikiUprawn { get; set; }
        /// <summary>
        /// Relacja do załącznika
        /// </summary>
        public int? ZalacznikiId { get; set; }
        /// <summary>
        /// Typ obiektu (U[ser], P[rofil])
        /// </summary>
        public string ObjTyp { get; set; }
        /// <summary>
        /// ID obiektu
        /// </summary>
        public int? ObjId { get; set; }
    }
}
