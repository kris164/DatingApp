using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EMiasto
    {
        public int IdEMiasto { get; set; }
        public int? KrajId { get; set; }
        public string Kod { get; set; }
        public string KodPoczta { get; set; }
        public string Miasto { get; set; }
        public string MiastoNopl { get; set; }
        public string Wojewodztwo { get; set; }
        public string Powiat { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
    }
}
