using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyHistZatr
    {
        public int IdKierowcyHistZatr { get; set; }
        public int KierowcyId { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string FormaZatrudnienia { get; set; }
        public string Umowa { get; set; }
        public string ZatrudnionyW { get; set; }
        public int? ZatrudnionyWId { get; set; }
    }
}
