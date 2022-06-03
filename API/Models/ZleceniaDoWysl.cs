using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Zlecenia do wysłania (na potrzeby SFM)
    /// </summary>
    public partial class ZleceniaDoWysl
    {
        public int IdZleceniaDoWysl { get; set; }
        /// <summary>
        /// Relacja do zlecenia, tab: ZLECENIA
        /// </summary>
        public int? ZlecenieId { get; set; }
        /// <summary>
        /// 0/1 - wyślij zlec. za pomocą SMS
        /// </summary>
        public short? TylkoSms { get; set; }
    }
}
