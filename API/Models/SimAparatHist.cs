using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SimAparatHist
    {
        public int IdSimAparatHist { get; set; }
        public int? SimId { get; set; }
        public DateTime? DataWymiany { get; set; }
        public string Model { get; set; }
        public string Typ { get; set; }
        public DateTime? DataProd { get; set; }
        public string Imei { get; set; }
    }
}
