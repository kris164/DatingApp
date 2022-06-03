using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Zlecenia zbiorcze - pozycje
    /// </summary>
    public partial class ZleceniaZbPoz
    {
        public int IdZleceniaZbPoz { get; set; }
        public int? ZleceniaZbId { get; set; }
        public int? ZlecenieId { get; set; }
    }
}
