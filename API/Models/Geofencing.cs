using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// tabela do obsługi geofencingu
    /// </summary>
    public partial class Geofencing
    {
        public int IdGeofencing { get; set; }
        public int PoiId { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
        public short? GfType { get; set; }
        public short? GfAlwaysValid { get; set; }
        public string GfName { get; set; }
        public short? GfRegion { get; set; }
        public int? GfRadiusX { get; set; }
        public int? GfRadiusY { get; set; }
        public short? GfDirEntering { get; set; }
        public short? GfDirLeaving { get; set; }
        public int? GfMaxDuration { get; set; }
        public short? FSendToBase { get; set; }
        public short? FBeepToDriver { get; set; }
        public short? FWarnToDriver { get; set; }
        public string WarnToDriver { get; set; }
        public DateTime? DtCreate { get; set; }
        public DateTime? DtGfEvent { get; set; }
        public DateTime? DtGfAdd { get; set; }
        public DateTime? DtGfDel { get; set; }
        public DateTime? DtToSend { get; set; }
        public DateTime? DtValidity { get; set; }
        public double? ALon { get; set; }
        public double? ALat { get; set; }
        public double? BLon { get; set; }
        public double? BLat { get; set; }
    }
}
