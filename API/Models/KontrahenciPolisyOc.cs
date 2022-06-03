using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje polis ubezp. OC kontrahenta
    /// </summary>
    public partial class KontrahenciPolisyOc
    {
        public int IdKontrahenciPolisyOc { get; set; }
        /// <summary>
        /// Typ polisy OC (OCP/OCS itd)
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Numer polisy ubezpieczenia przewoźnika
        /// </summary>
        public string Nr { get; set; }
        /// <summary>
        /// Ubezpieczyciel
        /// </summary>
        public string Ubezp { get; set; }
        /// <summary>
        /// Relacja do ubezpieczyciela - tab: KONTRAHENCI
        /// </summary>
        public int? UbezpId { get; set; }
        /// <summary>
        /// Data ważnosci ubezpieczenia OC przewoźnika
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Wartość ubezpieczenia OC przewoźnika
        /// </summary>
        public double? Wartosc { get; set; }
        /// <summary>
        /// Waluta wartości ubezpieczenia OC przewoźnika
        /// </summary>
        public string WartoscWaluta { get; set; }
        /// <summary>
        /// Flaga, czy jest blokada ubezpieczenia OC spedytora
        /// </summary>
        public int? DataBlokada { get; set; }
        /// <summary>
        /// Flaga, czy ubezpieczenie OC przewoźnika obejmuje kraj czy zagranice
        /// </summary>
        public int? KrajZagr { get; set; }
        /// <summary>
        /// Uwagi do ubezpieczenia OC przewoźnika
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Relacja do polisy - tab: POLISY
        /// </summary>
        public int? PolisaId { get; set; }
        /// <summary>
        /// Dla jakich krajów ważna
        /// </summary>
        public string Kraje { get; set; }
        /// <summary>
        /// Flaga, czy jest blokada gdy kraj spoza listy
        /// </summary>
        public int? KrajeBlokada { get; set; }
    }
}
