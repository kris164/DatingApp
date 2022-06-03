using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// domyślne definicje GF w POI:MIEJSCA_ZA_ROZLADUNKU dla obiektów różnych typów
    /// </summary>
    public partial class GfDefPoiObj
    {
        public int IdGfDefPoiObj { get; set; }
        /// <summary>
        /// id POI (referencja do tabeli MIEJSCA_ZA_ROZLADUNKU)
        /// </summary>
        public int? PoiId { get; set; }
        /// <summary>
        /// typ obiektu (11-LISTY_LINIOWE_ZA_WY /12-ZLECENIA_ZA_WY /200-GF_EVENT_DEF)
        /// </summary>
        public int? ObjTyp { get; set; }
        /// <summary>
        /// id definicji geofencingu (referencja do tabeli GF_DEF)
        /// </summary>
        public int? GfDefId { get; set; }
    }
}
