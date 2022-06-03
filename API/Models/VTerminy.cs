using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class VTerminy
    {
        public string Typ { get; set; }
        public string Rodzaj { get; set; }
        public DateTime? Data { get; set; }
        public string Opis { get; set; }
        public int? Dni { get; set; }
        public int? Id { get; set; }
        public int? IdRec { get; set; }
        public string RecKey { get; set; }
        public int? Licznik { get; set; }
        public string Uwagi { get; set; }
        public string Lokalizacja { get; set; }
        public string Uzytkownik { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string TaborB { get; set; }
        public int? KontrahId { get; set; }
        public string Kontrah { get; set; }
    }
}
