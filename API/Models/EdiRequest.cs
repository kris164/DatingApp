using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Tabela do extra przebiegów dla EDI_SRV
    /// </summary>
    public partial class EdiRequest
    {
        public int IdEdiRequest { get; set; }
        /// <summary>
        /// Data utworzenia
        /// </summary>
        public DateTime? CreateDt { get; set; }
        /// <summary>
        /// Data realizacji
        /// </summary>
        public DateTime? DoneDt { get; set; }
        /// <summary>
        /// stan realizacji  0 - zrobione, - 1 - nierealizowalne, 1 - do zrobienia
        /// </summary>
        public int? Flag { get; set; }
        /// <summary>
        /// numer funkcji wg wpisow ini - Funkcja_1 to 1
        /// </summary>
        public int? FunkcjaNr { get; set; }
        /// <summary>
        /// nazwa procesu, ktory wymusil przebieg
        /// </summary>
        public string Requester { get; set; }
        /// <summary>
        /// dodatkowe parametry dla procedury
        /// </summary>
        public string Params { get; set; }
    }
}
