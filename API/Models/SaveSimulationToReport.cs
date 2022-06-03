using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SaveSimulationToReport
    {
        public int? SessionId { get; set; }
        public int? MacierzZleceniaTaborId { get; set; }
        public string StatisticName { get; set; }
        public string StatisticValue { get; set; }
    }
}
