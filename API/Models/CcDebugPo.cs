using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CcDebugPo
    {
        public int Id { get; set; }
        public int? CcDebugId { get; set; }
        public int? IdSfmTerm { get; set; }
        public int? IdTabor { get; set; }
        public int? IdSfmPos { get; set; }
        public DateTime? Czas { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
        public double? Lon0 { get; set; }
        public double? Lat0 { get; set; }
        public double? Lon1 { get; set; }
        public double? Lat1 { get; set; }
        public double? Lon2 { get; set; }
        public double? Lat2 { get; set; }
        public int? IdSfmRoute { get; set; }
        public DateTime? DtAlert { get; set; }
        public int? IdKierowcy { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }

        public virtual CcDebug CcDebug { get; set; }
    }
}
