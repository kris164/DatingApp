using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProcedureCfgExt
    {
        public int IdProcedureCfgExt { get; set; }
        public int ProcedureCfgId { get; set; }
        /// <summary>
        /// Typ uprawnienia 0 - user, 1 - profil
        /// </summary>
        public int Typ { get; set; }
        /// <summary>
        /// Relacja do użytkownika, profilu
        /// </summary>
        public int ObiektId { get; set; }
        public string SqlExt { get; set; }
    }
}
