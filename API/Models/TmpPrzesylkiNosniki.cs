using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiNosniki
    {
        public int IdTmpPrzesylkiNosniki { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? Id { get; set; }
        public int? PrzesylkiId { get; set; }
        public string NrPrzesylki { get; set; }
        public string NrPrzesylkiEx { get; set; }
        public int? OpakowaniaId { get; set; }
        public string Kod { get; set; }
        public int? IleAwi { get; set; }
        public int? IlePod { get; set; }
        public int? IleDor { get; set; }
        public int? IleMpz { get; set; }
        public int? IleMwz { get; set; }
        public int? IleMrk { get; set; }
        public int? IleZwp { get; set; }
    }
}
