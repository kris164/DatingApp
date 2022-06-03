using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WGrupyPrzeglad
    {
        public int IdWGrupyPrzeglad { get; set; }
        public string Opis { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Wersja { get; set; }
    }
}
