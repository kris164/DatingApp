using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyUwagi
    {
        public int IdKierowcyUwagi { get; set; }
        public string Kierowca { get; set; }
        public int? KierowcaId { get; set; }
        public DateTime? Data { get; set; }
        public string Zrodlo { get; set; }
        public int? Typ { get; set; }
        public string Info { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public string Wyjazd { get; set; }
        public int? WyjazdId { get; set; }
        public string Zlecenie { get; set; }
        public int? ZlecenieId { get; set; }
        public string Rodzaj { get; set; }
        public string ListyLiniowe { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? Zamkniety { get; set; }
        public string Lokalizacja { get; set; }
        public int? ZamknietyUserId { get; set; }
        public string ZamknietyUser { get; set; }
        public DateTime? ZamknietyDt { get; set; }
        public string ZamknietyUwagi { get; set; }
        public int? Zalaczniki { get; set; }
    }
}
