using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpTaborKierowcyTeczka
    {
        public int IdTmpTaborKierowcyTeczka { get; set; }
        public int? IdSesjiKalk { get; set; }
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
