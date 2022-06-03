using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Sim
    {
        public int IdSim { get; set; }
        public string Numer { get; set; }
        public string NumerSim { get; set; }
        public string Operator { get; set; }
        public string Taryfa { get; set; }
        public int? Roaming { get; set; }
        public DateTime? UmOd { get; set; }
        public DateTime? UmDo { get; set; }
        public string Haslo { get; set; }
        public string Model { get; set; }
        public string Typ { get; set; }
        public string NrSer { get; set; }
        public DateTime? DataProd { get; set; }
        public string Pin { get; set; }
        public string Pin2 { get; set; }
        public string Puk1 { get; set; }
        public string Puk2 { get; set; }
        public string Imei { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public DateTime? KierowcaOd { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public DateTime? TaborOd { get; set; }
        public int? Prywatny { get; set; }
        public int? Aktywny { get; set; }
        public int? OperatorId { get; set; }
        public string Kraj { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string Uwagi { get; set; }
        public string NrLokalizatoraGps { get; set; }
    }
}
