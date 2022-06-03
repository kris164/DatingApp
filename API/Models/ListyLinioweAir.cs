using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozszerzenie tabeli LISTY_LINIOWE - relacja 1:1 z tabelą LISTY_LINIOWE
    /// </summary>
    public partial class ListyLinioweAir
    {
        public int IdListyLiniowe { get; set; }
        public string Mawb { get; set; }
        public int? KontrahAirAwbId { get; set; }
        public string NrLotu { get; set; }
        public DateTime? DataLotu { get; set; }
        public DateTime? DataCutoff { get; set; }
        public double? SumAirIlosc { get; set; }
        public double? SumAirWagaRz { get; set; }
        public double? SumAirWagaObj { get; set; }
        public double? SumAirWagaPlatna { get; set; }
        public double? SumAirObjRz { get; set; }
    }
}
