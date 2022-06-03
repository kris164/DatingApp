using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Reversegeocoding
    {
        public int IdReversegeocoding { get; set; }
        /// <summary>
        /// długość geograficzna pozycji badanej
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// szerokość geograficzna pozycji badanej
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// długość geograficzna pozycji adresu
        /// </summary>
        public double? LonOrg { get; set; }
        /// <summary>
        /// szerokość geograficzna pozycji adresu
        /// </summary>
        public double? LatOrg { get; set; }
        /// <summary>
        /// odległość w metrach pozycji badanej od pozycji adresu
        /// </summary>
        public int? Distance { get; set; }
        /// <summary>
        /// kraj - kod ISO
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// kod pocztowy
        /// </summary>
        public string Zipcode { get; set; }
        /// <summary>
        /// miejscowość
        /// </summary>
        public string Place { get; set; }
        /// <summary>
        /// adres
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// województwo / okręg
        /// </summary>
        public string Province { get; set; }
        public string Address { get; set; }
    }
}
