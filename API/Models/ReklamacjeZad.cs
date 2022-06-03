using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReklamacjeZad
    {
        public int IdReklamacjeZad { get; set; }
        public int? ReklamacjeId { get; set; }
        public int? ReklSchematId { get; set; }
        public int? ReklSchematPozId { get; set; }
        public int? Lp { get; set; }
        public string Akcja { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Uwagi { get; set; }
        public DateTime? Termin { get; set; }
        public DateTime? DataRealizacji { get; set; }
        public int? Wykonane { get; set; }
        public int? PracownikId { get; set; }
        public string Pracownik { get; set; }
    }
}
