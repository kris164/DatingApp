using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmRoutePoi
    {
        public int IdSfmRoutePoi { get; set; }
        /// <summary>
        /// ID wyznaczonej trasy
        /// </summary>
        public int IdSfmRoute { get; set; }
        /// <summary>
        /// GPS E/W (+/-)
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// GPS N/S (+/-)
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// kierunek względem pólnocy (0-360)
        /// </summary>
        public int? Direction { get; set; }
        /// <summary>
        /// rodzaj punktu (0-via /1-POI /2-detail)
        /// </summary>
        public short? Kind { get; set; }
        /// <summary>
        /// opis punktu trasy
        /// </summary>
        public string Description { get; set; }
    }
}
