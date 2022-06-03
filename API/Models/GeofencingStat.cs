using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// tabela do rejestrowania statusu geofencingu dla pojazdu
    /// </summary>
    public partial class GeofencingStat
    {
        public int IdGeofencingStat { get; set; }
        public int IdGeofencing { get; set; }
        public int IdTabor { get; set; }
        public int? IdExt { get; set; }
        public int? IdExt1 { get; set; }
        public short? GfReady { get; set; }
        public short? GfInternal { get; set; }
        public string GfError { get; set; }
        public short? GfStatAdd { get; set; }
        public short? GfStatDel { get; set; }
        public DateTime? DtGfAdd { get; set; }
        public DateTime? DtGfDel { get; set; }
        public DateTime? GfEnterDt { get; set; }
        public double? GfEnterLon { get; set; }
        public double? GfEnterLat { get; set; }
        public DateTime? GfLeaveDt { get; set; }
        public double? GfLeaveLon { get; set; }
        public double? GfLeaveLat { get; set; }
    }
}
