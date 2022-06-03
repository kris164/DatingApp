using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozszerzenie tabeli LISTY_LINIOWE - relacja 1:1 z tabelą LISTY_LINIOWE
    /// </summary>
    public partial class ListyLinioweRail
    {
        public int IdListyLiniowe { get; set; }
        public DateTime? DataCutoff { get; set; }
        public DateTime? DataCutoffVgm { get; set; }
        public DateTime? DataDoCennika { get; set; }
        public int? BuyersConsol { get; set; }
        public string NumerSc { get; set; }
        public string TypKonsolidacji { get; set; }
        public double? SumRailIlosc { get; set; }
        public double? SumRailWagaRz { get; set; }
        public double? SumRailWagaObj { get; set; }
        public double? SumRailWagaPlatna { get; set; }
        public double? SumRailObjRz { get; set; }
        public int? OperatorId { get; set; }
        public string Operator { get; set; }
        public string OperatorKont { get; set; }
        public string NazwaPociagu { get; set; }
        public string AwizacjaRail { get; set; }
    }
}
