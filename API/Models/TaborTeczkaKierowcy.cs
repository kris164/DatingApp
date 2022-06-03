using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborTeczkaKierowcy
    {
        public int IdTaborTeczkaKierowcy { get; set; }
        public int TaborId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        public DateTime? DataWaznosci { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public int? Arch { get; set; }
        public DateTime? DataArch { get; set; }
        public string Uwagi { get; set; }
    }
}
