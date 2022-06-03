using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje do harmonogramu tras międzyoddziałowych - detal do ROUTE_TIMETAB
    /// </summary>
    public partial class RouteTimetabPoz
    {
        public int IdRouteTimetabPoz { get; set; }
        /// <summary>
        /// Relacja do harmonogramu - tab: ROUTE_TIMETAB
        /// </summary>
        public int? RouteTimetabId { get; set; }
        public int? ZaDzienTyg { get; set; }
        public DateTime? ZaGodz { get; set; }
        public int? WyDzienTyg { get; set; }
        public DateTime? WyGodz { get; set; }
        public DateTime? ZaCzasTrwania { get; set; }
        public DateTime? WyCzasTrwania { get; set; }
        public string StanTrasy { get; set; }
        public int? ViaDzienTyg { get; set; }
        public DateTime? ViaGodz { get; set; }
        public DateTime? ViaCzasTrwania { get; set; }
        public int? ZaHubgateid { get; set; }
        public int? ViaHubgateid { get; set; }
        public int? WyHubgateid { get; set; }
        public int? Via2DzienTyg { get; set; }
        public DateTime? Via2Godz { get; set; }
        public DateTime? Via2CzasTrwania { get; set; }
        public int? Via2Hubgateid { get; set; }
        public DateTime? ViaGodzZa { get; set; }
        public DateTime? Via2GodzZa { get; set; }
    }
}
