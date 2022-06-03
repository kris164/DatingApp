using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// definicja geofencingu
    /// </summary>
    public partial class GfDef
    {
        public int IdGfDef { get; set; }
        /// <summary>
        /// typ obiektu (11-LISTY_LINIOWE_ZA_WY /12-ZLECENIA_ZA_WY /200-GF_EVENT_DEF)
        /// </summary>
        public int? ObjTyp { get; set; }
        /// <summary>
        /// nazwa geofencingu &lt;gf-send&gt;
        /// </summary>
        public string GfName { get; set; }
        /// <summary>
        /// opis definicji geofencingu
        /// </summary>
        public string GfDescr { get; set; }
        /// <summary>
        /// promień okręgu w metrach &lt;gf-send&gt;
        /// </summary>
        public int? Radius { get; set; }
        /// <summary>
        /// id akcji dla wjazdu do strefy
        /// </summary>
        public int? ActionEnterId { get; set; }
        /// <summary>
        /// id akcji dla wyjazdu ze strefy
        /// </summary>
        public int? ActionExitId { get; set; }
        /// <summary>
        /// id akcji dla przekroczenia czasu pobytu w strefie
        /// </summary>
        public int? ActionDurationId { get; set; }
        /// <summary>
        /// id akcji dla ETA (kontrola czasu dojazdu do strefy)
        /// </summary>
        public int? ActionEtaId { get; set; }
        /// <summary>
        /// typ zdarzenia za/wy
        /// </summary>
        public string TaskType { get; set; }
    }
}
