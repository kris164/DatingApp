using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosElc
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
    }
}
