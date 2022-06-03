using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WezwaniaDoZaplPoz
    {
        public int IdWezwaniaDoZaplPoz { get; set; }
        public int? WezwaniaDoZaplId { get; set; }
        public string Typ { get; set; }
        public int? FakturyId { get; set; }
        public string Faktury { get; set; }
        public int? LiczbaDni { get; set; }
        public double? Odsetki { get; set; }
        public double? KwotaZadluzenia { get; set; }
        public string Waluta { get; set; }
    }
}
