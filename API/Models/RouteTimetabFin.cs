using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RouteTimetabFin
    {
        public int IdRouteTimetabFin { get; set; }
        /// <summary>
        /// Relacja do harmonogramu - tab: ROUTE_TIMETAB
        /// </summary>
        public int? RouteTimetabId { get; set; }
        public int? Lp { get; set; }
        public string Dotyczy { get; set; }
        public string Typ { get; set; }
        public double? Stawka { get; set; }
    }
}
