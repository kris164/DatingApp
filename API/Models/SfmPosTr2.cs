using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosTr2
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
    }
}
