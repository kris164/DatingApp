using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Schematy tras międzyoddziałowych
    /// </summary>
    public partial class RouteInterhub
    {
        public int IdRouteInterhub { get; set; }
        /// <summary>
        /// Symbol schematu
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Z jakiej lokalizacji
        /// </summary>
        public string LokalizacjaOd { get; set; }
        /// <summary>
        /// Do jakiej lokalizacji
        /// </summary>
        public string LokalizacjaDo { get; set; }
        /// <summary>
        /// W godzinach od
        /// </summary>
        public DateTime? GodzOd { get; set; }
        /// <summary>
        /// W godzinach do
        /// </summary>
        public DateTime? GodzDo { get; set; }
    }
}
