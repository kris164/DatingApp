using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class StatusyJpk
    {
        public int IdStatusyJpk { get; set; }
        public int? Code { get; set; }
        /// <summary>
        /// Opis statusu
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Szczegóły zdarzenia
        /// </summary>
        public string Details { get; set; }
        /// <summary>
        /// Treść Urzędowego Poświadczenia Odbioru
        /// </summary>
        public string Upo { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string ReferenceNumber { get; set; }
    }
}
