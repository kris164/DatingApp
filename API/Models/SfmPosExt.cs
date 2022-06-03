using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosExt
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// symbol kraju
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// licznik kilometrów [km]
        /// </summary>
        public int? Lkm { get; set; }
        /// <summary>
        /// id znalezionego adresu
        /// </summary>
        public int? IdReversegeocoding { get; set; }
        /// <summary>
        /// odległość w metrach od znalezionego adresu
        /// </summary>
        public int? Distance { get; set; }
        /// <summary>
        /// licznik paliwa [L]
        /// </summary>
        public int? Tfu { get; set; }
        /// <summary>
        /// poziom paliwa w zbiorniku [L]
        /// </summary>
        public double? Fla { get; set; }
        /// <summary>
        /// czas pomiaru pozycji [UTC]
        /// </summary>
        public DateTime? Dtutc { get; set; }
        /// <summary>
        /// id pojazdu (syst. zewn.)
        /// </summary>
        public string Vehid { get; set; }
        /// <summary>
        /// id naczepy (syst. zewn.)
        /// </summary>
        public string Traid { get; set; }
        /// <summary>
        /// id kierowcy1 (syst. zewn.)
        /// </summary>
        public string Drvid1 { get; set; }
        /// <summary>
        /// id kierowcy2 (syst. zewn.)
        /// </summary>
        public string Drvid2 { get; set; }
        /// <summary>
        /// droga w metrach między aktualną pozycją a poprzednią
        /// </summary>
        public int? DeltaDistance { get; set; }
    }
}
