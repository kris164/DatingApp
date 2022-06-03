using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// lista walut rejestrowanych w tabeli
    /// </summary>
    public partial class TabkursowWaluty
    {
        public int IdTabkursowWaluty { get; set; }
        /// <summary>
        /// typ tabeli (liczone od 3)
        /// </summary>
        public short? Typ { get; set; }
        /// <summary>
        /// kod waluty
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// nazwa waluty
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// przelicznik waluty
        /// </summary>
        public short? KursNa { get; set; }
    }
}
