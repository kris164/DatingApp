using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TekstyCrm
    {
        public int IdTekstyCrm { get; set; }
        /// <summary>
        /// Symbol kontaktu CRM
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Cel kontaktu
        /// </summary>
        public string KontCel { get; set; }
        /// <summary>
        /// Tekst wiadomości
        /// </summary>
        public string Tekst { get; set; }
    }
}
