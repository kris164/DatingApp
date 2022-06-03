using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlKier
    {
        public int IdRozlKier { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public string Uwagi { get; set; }
        public DateTime? KursData { get; set; }
        public int? KursTabelaId { get; set; }
        public string KursTabela { get; set; }
        public int? KursTabelaTyp { get; set; }
        public string KursRodzaj { get; set; }
        public double? Suma { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
