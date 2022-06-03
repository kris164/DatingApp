using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik parametrów dla grup ładunków
    /// </summary>
    public partial class GrupyLadunkowParametry
    {
        public int IdGrupyLadunkowParametry { get; set; }
        public int GrupyLadunkowId { get; set; }
        public int? KontrahId { get; set; }
        public int? MiejscaZaRozladunkuId { get; set; }
        public int? Kontrola { get; set; }
        public double? Wartosc { get; set; }
        public int? GrupaLadunkuPoId { get; set; }
        public string ProceduraMyciaPo { get; set; }
    }
}
