using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WindykacjeZad
    {
        public int IdWindykacjeZad { get; set; }
        public int? WindykacjeId { get; set; }
        public int? WindSchematId { get; set; }
        public int? WindSchematPozId { get; set; }
        public int? Lp { get; set; }
        public string Akcja { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Uwagi { get; set; }
        public DateTime? Termin { get; set; }
        public DateTime? DataRealizacji { get; set; }
        public int? Wykonane { get; set; }
    }
}
