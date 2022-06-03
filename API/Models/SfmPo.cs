using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPo
    {
        public int IdSfmPos { get; set; }
        public short? Zapytanie { get; set; }
        public int IdSfmTerm { get; set; }
        public string TypTerm { get; set; }
        public int IdKierowcy { get; set; }
        public int IdNaczepy { get; set; }
        public int? Crc { get; set; }
        public DateTime? Czas { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public short? Kierunek { get; set; }
        public string Silnik { get; set; }
        public int? Predkosc { get; set; }
        public int? Obroty { get; set; }
        public short? Zrobione { get; set; }
        public int? OdlOdTrasy { get; set; }
        public int? IdKierowcy2 { get; set; }
        public int? IdTabor { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public string DeviceInfo { get; set; }
        public string SourceInfo { get; set; }
        public double? Angle { get; set; }
        public int? Done { get; set; }
        public int? Satellite { get; set; }
        public double? Battery { get; set; }
        public double? OdlLat { get; set; }
        public double? OdlLon { get; set; }
        public DateTime? DtSave { get; set; }
        public double? TotalAxleLoad { get; set; }
        public int? DoorsOpen { get; set; }
    }
}
