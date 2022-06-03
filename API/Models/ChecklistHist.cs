using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ChecklistHist
    {
        public int IdChecklistHist { get; set; }
        /// <summary>
        /// id pojazdu
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id kierowcy
        /// </summary>
        public int? IdKierowca { get; set; }
        /// <summary>
        /// nazwa kierowcy
        /// </summary>
        public string Kierowca { get; set; }
        /// <summary>
        /// data check-listy
        /// </summary>
        public DateTime? Dt { get; set; }
        /// <summary>
        /// data zapisu
        /// </summary>
        public DateTime? DtZapis { get; set; }
    }
}
