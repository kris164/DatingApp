using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje schematu tras międzyoddziałowych - detal do ROUTE_INTERHUB
    /// </summary>
    public partial class RouteInterhubPoz
    {
        public int IdRouteInterhubPoz { get; set; }
        /// <summary>
        /// Relacja do schematu - tab: ROUTE_INTERHUB
        /// </summary>
        public int? RouteInterhubId { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
    }
}
