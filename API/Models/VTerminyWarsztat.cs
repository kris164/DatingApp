using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class VTerminyWarsztat
    {
        public string Rodzaj { get; set; }
        public string Zdarzenie { get; set; }
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
    }
}
