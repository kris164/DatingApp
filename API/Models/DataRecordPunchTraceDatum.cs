using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DataRecordPunchTraceDatum
    {
        public int IdDataRecordPunchTraceData { get; set; }
        public int? SystemId { get; set; }
        public int? DataRecordId { get; set; }
        public int? TraceLp { get; set; }
        public int? TraceType { get; set; }
        public int? IsTablet { get; set; }
        public int? IsLocation { get; set; }
        public int? IsDriverReport { get; set; }
        public int? IsTraceReport { get; set; }
        public int? IdSfmPos { get; set; }
        public DateTime? TimeStartUtc { get; set; }
        public DateTime? TimeUtc { get; set; }
        public DateTime? TimeStartLocal { get; set; }
        public DateTime? TimeLocal { get; set; }
        public double? DurationSec { get; set; }
        public double? DriveDurationSec { get; set; }
        public int? Distance { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public int? Direction { get; set; }
        public int? Speed { get; set; }
        public double? Lkm { get; set; }
        public int? Tfu { get; set; }
        public double? Fla { get; set; }
        public int? DriverId1 { get; set; }
        public int? DriverId2 { get; set; }
        public int? TerminalId { get; set; }
        public int? VehicleId { get; set; }
        public string ExtDriverId1 { get; set; }
        public string ExtDriverId2 { get; set; }
        public string ExtVehicleId { get; set; }
        public string ExtTabletId { get; set; }
        public string SrcDriverId { get; set; }
        public string SrcVehicleId { get; set; }
        public string SrcTrailerId { get; set; }
        public string PlaceId { get; set; }
        public int? ObjType { get; set; }
        public int? ObjId { get; set; }
        public int? ObjStatStart { get; set; }
        public int? ObjStatStop { get; set; }
        public string SesionLty { get; set; }
        public string SesionMode { get; set; }
        public DateTime? SesionLoginDt { get; set; }
        public int? ReverseGeocodingId { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Province { get; set; }
        public string Place { get; set; }
        public string Street { get; set; }
        public byte[] ReportForTraceType { get; set; }
        public byte[] Report { get; set; }
        public string Params { get; set; }
        public string TraceData { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
