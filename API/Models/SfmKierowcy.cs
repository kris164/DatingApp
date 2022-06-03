using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmKierowcy
    {
        public int IdSfmKierowcy { get; set; }
        /// <summary>
        /// ID kierowcy w SPEED
        /// </summary>
        public int? IdKierowcy { get; set; }
        /// <summary>
        /// ID kierowcy w syst. zewnętrznym
        /// </summary>
        public string IdExt { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// (0/1) wysłać do syst. zewnętrznego?
        /// </summary>
        public short? Sendtoterm { get; set; }
        /// <summary>
        /// status wysyłki danych kierowcy
        /// </summary>
        public string Sendstatus { get; set; }
    }
}
