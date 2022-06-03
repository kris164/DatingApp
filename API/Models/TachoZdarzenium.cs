using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TachoZdarzenium
    {
        public int IdTachoZdarzenia { get; set; }
        public int IdTacho { get; set; }
        public int? Lp { get; set; }
        public string Tryb { get; set; }
        public DateTime? CzasOd { get; set; }
        public DateTime? CzasDo { get; set; }
        public DateTime? CzasTrwania { get; set; }
        public double? Km { get; set; }
        public int? XStart { get; set; }
        public int? XStop { get; set; }
        public string Uwagi { get; set; }
        public int IdKierowcy { get; set; }
        public int IdTaboru { get; set; }
        public DateTime? DataczasOd { get; set; }
        public DateTime? DataczasDo { get; set; }
        public short? Zespolowa { get; set; }
        public short? Cyfrowe { get; set; }
        public string TrybKorekta { get; set; }
        public short? IsManual { get; set; }
        public int? DeltaOd { get; set; }
        public int? DeltaDo { get; set; }
    }
}
