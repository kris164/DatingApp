using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReklRodzUszk
    {
        public int IdReklRodzUszk { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int? Waznosc { get; set; }
        public int? GrupaId { get; set; }
    }
}
