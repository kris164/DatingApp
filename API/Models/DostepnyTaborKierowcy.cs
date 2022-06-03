using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DostepnyTaborKierowcy
    {
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdKierowcy { get; set; }
        public int? IdTaboru { get; set; }
        public int? IdNaczepy { get; set; }
        public string UplywajacyTermDokTypDok { get; set; }
        public DateTime? UplywajacyTermDokData { get; set; }
        public string Zjazd { get; set; }
        public DateTime? TerminZjazdu { get; set; }
        public string KierowcaKraj { get; set; }
        public string KierowcaBlokadaKraj { get; set; }
        public int? KierowcaBlokadaPoi { get; set; }
        public string KierowcaBlokadaLad { get; set; }
        public int? KierowcaBlokadaNaWywiekszeOd2 { get; set; }
        public int? GranicznaDlugoscTrasy { get; set; }
        public int? KierowcaZgodaNaTrasyDluzszeNizGranicznaDlugoscTrasy { get; set; }
        public string ZjazdWeekendpwyTyp { get; set; }
        public DateTime? ZjazdWeekendpwyData { get; set; }
        public int? ZjazdWeekendpwyPoiid { get; set; }
        public double? ZjazdWeekendpwyPoiLon { get; set; }
        public double? ZjazdWeekendpwyPoiLat { get; set; }
    }
}
