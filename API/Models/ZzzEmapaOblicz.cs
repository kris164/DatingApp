using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZzzEmapaOblicz
    {
        public int IdZzzEmapaOblicz { get; set; }
        /// <summary>
        /// Id zlecenia
        /// </summary>
        public int ZlecenieId { get; set; }
        /// <summary>
        /// status
        /// </summary>
        public int Obliczone { get; set; }
    }
}
