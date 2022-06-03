using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OpakowaniaPoz
    {
        public int IdOpakowaniaPoz { get; set; }
        public int? OpakowaniaId { get; set; }
        public short? Operacja { get; set; }
        public DateTime? Data { get; set; }
        public short? Ilosc { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? KontrahentId { get; set; }
        public string Kontrahent { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string Uwagi { get; set; }
        public string Lokalizacja { get; set; }
    }
}
