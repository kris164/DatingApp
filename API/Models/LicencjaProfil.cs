using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LicencjaProfil
    {
        public int IdLicencjaProfil { get; set; }
        public string Stanowisko { get; set; }
        public int Ilosc { get; set; }
        public int Terminal { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Hash { get; set; }
        public string Program { get; set; }
        public int Podglad { get; set; }
        public int? Admin { get; set; }
    }
}
