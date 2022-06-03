using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmVdfZawyStat
    {
        public int IdSfmVdfZawyStat { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// ID terminala w bazie SFM
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// ID wiadomości źródłowej
        /// </summary>
        public int? IdSfmMsg { get; set; }
        /// <summary>
        /// liczbowe oznaczenie statusu Volvo
        /// </summary>
        public int? NrStat { get; set; }
        /// <summary>
        /// data/czas statusu Volvo
        /// </summary>
        public DateTime? DtStat { get; set; }
        /// <summary>
        /// data/czas zapisu rekordu
        /// </summary>
        public DateTime? DtZapis { get; set; }
    }
}
