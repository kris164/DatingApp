using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LicencjaModul
    {
        public int IdLicencjaModul { get; set; }
        public int ProfilId { get; set; }
        public string Symbol { get; set; }
        public string Opis { get; set; }
        public DateTime Dataczas { get; set; }
        public string Hash { get; set; }
    }
}
