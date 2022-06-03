using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozszerzenie tabeli LISTY_LINIOWE - relacja 1:1 z tabelą LISTY_LINIOWE
    /// </summary>
    public partial class ListyLinioweSea
    {
        public int IdListyLiniowe { get; set; }
        public string Hbl { get; set; }
        public string Mbl { get; set; }
        public DateTime? DataCutoff { get; set; }
        public int? ArmatorId { get; set; }
        public string Armator { get; set; }
        public string ArmatorKont { get; set; }
        public string ArmatorTel { get; set; }
        public string Statek { get; set; }
        public string NrRejsu { get; set; }
        public string TypKonsolidacji { get; set; }
        public int? BuyersConsol { get; set; }
        public double? SumSeaIlosc { get; set; }
        public double? SumSeaWagaRz { get; set; }
        public double? SumSeaWagaObj { get; set; }
        public double? SumSeaWagaPlatna { get; set; }
        public double? SumSeaObjRz { get; set; }
        public DateTime? DataCutoffVgm { get; set; }
        public DateTime? DataDoCennika { get; set; }
        public string NumerSc { get; set; }
    }
}
