using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// (OBJ_TYP=200) definicja zdarzenia geofencingu
    /// </summary>
    public partial class GfEventDef
    {
        public int IdGfEventDef { get; set; }
        /// <summary>
        /// id definicji geofencingu (referencja do tabeli GF_DEF)
        /// </summary>
        public int? GfDefId { get; set; }
        /// <summary>
        /// id POI (referencja do tabeli MIEJSCA_ZA_ROZLADUNKU)
        /// </summary>
        public int? PoiId { get; set; }
        /// <summary>
        /// długość geograficzna &lt;gf-send&gt;
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// szerokość geograficzna &lt;gf-send&gt;
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// maksymalny czas pobytu w strefie w sekundach &lt;gf-send&gt;
        /// </summary>
        public int? Maxduration { get; set; }
        /// <summary>
        /// opis zdarzenia (np. adres lub nazwa strefy)
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        /// max. termin próby wysyłki do pojazdu
        /// </summary>
        public DateTime? DtTosend { get; set; }
        /// <summary>
        /// data ważności geofencingu &lt;gf-send&gt;
        /// </summary>
        public DateTime? DtValidity { get; set; }
        /// <summary>
        /// opis POI lub GPS (nazwa; adres; kod; miasto; kraj)
        /// </summary>
        public string Poi { get; set; }
    }
}
