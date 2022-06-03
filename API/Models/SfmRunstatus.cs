using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmRunstatus
    {
        public int IdSfmRunstatus { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public string TypTerm { get; set; }
        public DateTime? Dt { get; set; }
        public short? Aktywny { get; set; }
    }
}
