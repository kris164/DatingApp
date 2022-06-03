using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SimHist
    {
        public int IdSimHist { get; set; }
        public int? SimId { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public DateTime? KierowcaOd { get; set; }
        public DateTime? KierowcaDo { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public DateTime? TaborOd { get; set; }
        public DateTime? TaborDo { get; set; }
        public string Sim { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? DataDo { get; set; }
        public DateTime? GodzDo { get; set; }
        public string Obiekt { get; set; }
        public string InfoDod { get; set; }
    }
}
