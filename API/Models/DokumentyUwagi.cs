using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DokumentyUwagi
    {
        public int IdDokumentyUwagi { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public double? Procent { get; set; }
    }
}
