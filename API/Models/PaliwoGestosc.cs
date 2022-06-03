using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PaliwoGestosc
    {
        public int IdPaliwoGestosc { get; set; }
        /// <summary>
        /// rodzaj paliwa
        /// </summary>
        public string Rodzaj { get; set; }
        /// <summary>
        /// gęstość paliwa 1 15°C
        /// </summary>
        public double? Gestosc { get; set; }
        /// <summary>
        /// opis
        /// </summary>
        public string Opis { get; set; }
    }
}
