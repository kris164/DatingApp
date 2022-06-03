using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrDane
    {
        public int IdWynagrDane { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public DateTime? KursData { get; set; }
        public int? KursTabelaId { get; set; }
        public string KursTabela { get; set; }
        public int? KursTabelaTyp { get; set; }
        public string KursRodzaj { get; set; }
        public string Status { get; set; }
        public DateTime? DataZamkniecia { get; set; }
        public string Opis { get; set; }
        public string Wyjazdy { get; set; }
        public int? WyjazdyWgDaty { get; set; }
        public string Zlecenia { get; set; }
        public int? ZleceniaWgDaty { get; set; }
        public DateTime? OstEdycjaDt { get; set; }
        public string OstEdycjaUser { get; set; }
    }
}
