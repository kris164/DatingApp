using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// dodatkowy filtr wiadomości do przekierowania
    /// </summary>
    public partial class PrzekFiltr
    {
        public int IdPrzekFiltr { get; set; }
        /// <summary>
        /// ID przekierowania
        /// </summary>
        public int IdPrzekierowania { get; set; }
        /// <summary>
        /// kod filtra
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// nazwa filtra
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// wiadomość tekstowa (-1/0/1)
        /// </summary>
        public short? FiltrTxt { get; set; }
        /// <summary>
        /// wiadomość systemowa (-1/0/1)
        /// </summary>
        public short? FiltrSys { get; set; }
        /// <summary>
        /// alert (-1/0/1)
        /// </summary>
        public short? FiltrAlert { get; set; }
        /// <summary>
        /// wiadomość do zlecenia (-1/0/1)
        /// </summary>
        public short? FiltrZlec { get; set; }
        /// <summary>
        /// warunek dodatkowy
        /// </summary>
        public string WarunekDod { get; set; }
    }
}
