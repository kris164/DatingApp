using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborKierowcyTeczka
    {
        public int IdTaborKierowcyTeczka { get; set; }
        public int? TaborKierowcyId { get; set; }
        public string Typ { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        public DateTime? DataWaznosci { get; set; }
        public int? SamNacz { get; set; }
        public string Zrodlo { get; set; }
    }
}
